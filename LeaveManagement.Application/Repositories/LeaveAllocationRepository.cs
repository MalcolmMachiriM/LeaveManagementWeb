using AutoMapper;
using AutoMapper.QueryableExtensions;
using LeaveManagement.Common.Constants;
using LeaveManagement.Application.Contracts;
using LeaveManagement.Data;
using LeaveManagement.Common.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI.Services;
using Microsoft.EntityFrameworkCore;

namespace LeaveManagement.Application.Repositories
{
    public class LeaveAllocationRepository : GenericRepository<LeaveAllocation>, ILeaveAllocationRepository
    {
        private readonly ApplicationDbContext context;
        private readonly UserManager<Employee> userManager;
        private readonly ILeaveTypeRepository leaveTypeRepository;
        private readonly IMapper mapper;
        private readonly AutoMapper.IConfigurationProvider configurationProvider;
        private readonly IEmailSender emailSender;

        public LeaveAllocationRepository(ApplicationDbContext context, 
            UserManager<Employee> userManager, ILeaveTypeRepository leaveTypeRepository,
            IMapper mapper, AutoMapper.IConfigurationProvider configurationProvider
            ,IEmailSender emailSender
            ) : base(context)
        {
            this.context = context;
            this.userManager = userManager;
            this.leaveTypeRepository = leaveTypeRepository;
            this.mapper = mapper;
            this.configurationProvider = configurationProvider;
            this.emailSender = emailSender;
        }

        public async Task<bool> AllocationExists(string employeeId, int leaveTypeID, int period)
        {
            return await context.LeaveAllocations.AnyAsync(q => q.EmployeeId == employeeId 
            &&  q.LeaveTypeId == leaveTypeID && q.Period  ==period);
        }

        public async Task<EmployeeAllocationVM> GetEmployeeAllocations(string employeeId)
        {
            var allocations = await context.LeaveAllocations
                .Include(q=> q.LeaveType)
                .Where(q=> q.EmployeeId ==employeeId)
                .ProjectTo<LeaveAllocationVM>(configurationProvider)
                .ToListAsync(); //select * from LeaveAllocations inner join LeaveType where employeeId=
            var employee = await userManager.FindByIdAsync(employeeId);

            var employeeAllocationModel  = mapper.Map<EmployeeAllocationVM>(employee);
            //employeeAllocationModel.LeaveAllocations = mapper.Map<List<LeaveAllocationVM>>(allocations);//this was without projectTo
            employeeAllocationModel.LeaveAllocations = (allocations);

            return employeeAllocationModel;
        }
        
        public async Task<LeaveAllocationEditVM> GetEmployeeAllocation(int Id)
        {
            var allocation = await context.LeaveAllocations
                .Include(q=> q.LeaveType)
                .FirstOrDefaultAsync(q=> q.Id ==Id);

            if (allocation == null)
            {
                return null;
            }

            var employee = await userManager.FindByIdAsync(allocation.EmployeeId);

            var model  = mapper.Map<LeaveAllocationEditVM>(allocation);
            model.Employee = mapper.Map<EmployeeListVM>(employee);

            return model;
        }

        public async Task LeaveAllocation(int leaveTypeId)
        {
            var employees = await userManager.GetUsersInRoleAsync(Roles.User);
            var period = DateTime.Now.Year;
            var leaveType = await leaveTypeRepository.GetAsync(leaveTypeId);
            var allocations = new List<LeaveAllocation>();

            var employeesWithNewAllocations = new List<Employee>();

            foreach (var employee in employees)
            {
                if (await AllocationExists(employee.Id, leaveTypeId, period))
                    continue;

                 allocations.Add(  new LeaveAllocation
                {
                    EmployeeId = employee.Id,
                    LeaveTypeId = leaveTypeId,
                    Period = period,
                    NumberOfDays = leaveType.DefaultDays
                });
                employeesWithNewAllocations.Add( employee );
            }
            await AddRangeAsync(allocations);

            foreach (var employee in employeesWithNewAllocations)
            {
                
                await emailSender.SendEmailAsync(employee.Email, $"Leave Allocation Posted for {period} ", $"Your leave {leaveType.Name} " +
                    $" has been posted for the given period");
            }
        }

        public async Task<bool> UpdateEmployeeAllocation(LeaveAllocationVM model)
        {
            var leaveAllocation = await GetAsync(model.Id);
            if (leaveAllocation == null)
            {
                return false;
            }
            leaveAllocation.Period = model.Period;
            leaveAllocation.NumberOfDays = model.NumberOfDays;
            await UpdateAsync(leaveAllocation);

            return true;
        }

        public async Task<LeaveAllocation?> GetEmployeeAllocation(string employeeId, int leaveTypeId)
        {
            return await context.LeaveAllocations.FirstOrDefaultAsync(q=>q.EmployeeId ==employeeId && q.LeaveTypeId == leaveTypeId);
        }
    }
}
