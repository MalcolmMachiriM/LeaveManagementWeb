using AutoMapper;
using LeaveManagement.Web.Data;

namespace LeaveManagement.Web.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig() 
        { 
            CreateMap<LeaveType,LeaveTypeVM> 
        }
    }
}
