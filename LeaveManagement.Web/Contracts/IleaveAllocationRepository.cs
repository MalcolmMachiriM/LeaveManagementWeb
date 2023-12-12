using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Contracts
{
    public interface IleaveAllocationRepository : IGenericRepository<LeaveAllocation>
    {
        Task LeaveAllocation(int leaveTypeId);
    }
}
