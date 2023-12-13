using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Contracts
{
    public interface IleaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
        Task<bool> AllocationExists(string employeeId, int leaveTypeID, int period); 
    }
}
