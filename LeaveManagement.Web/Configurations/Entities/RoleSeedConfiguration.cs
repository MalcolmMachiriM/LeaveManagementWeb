using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                     new IdentityRole
                     {
                         Id = "73ad90b0-1728-44eb-1995-283f579e4764",
                         Name = Roles.Administrator,
                         NormalizedName = Roles.Administrator.ToUpper(),
                     },
                     new IdentityRole
                     {
                         Id = "73ad90b0-1234-7896-9587-283f579e4764",
                         Name = Roles.User,
                         NormalizedName = Roles.User.ToUpper(),
                     }
                );
        }
    }
}