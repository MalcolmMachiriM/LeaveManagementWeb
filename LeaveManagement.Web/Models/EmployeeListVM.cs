namespace LeaveManagement.Web.Models
{
    public class EmployeeListVM
    {
        public string Id { get; set; }
        [D]
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string DateJoined { get; set; }
    }
}
