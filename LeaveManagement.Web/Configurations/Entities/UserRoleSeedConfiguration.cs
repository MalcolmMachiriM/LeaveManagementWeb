using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    internal class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "73ad90b0-1728-44eb-1995-283f579e4764",
                    UserId = "e18dc662-c956-45fc-a834-63128024ce27"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "73ad90b0-1234-7896-9587-283f579e4764",
                    UserId = "73ad90b0-4238-44eb-9587-283f579e4764"
                }
                );
        }

       
    }
}