using LeaveManagement.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Data.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData
                (
                    new Employee
                    {
                        Id = "e18dc662-c956-45fc-a834-63128024ce27",
                        Email = "admin@localhost.com",
                        NormalizedEmail = "ADMIN@LOCALHOST.COM",
                        NormalizedUserName = "ADMIN@LOCALHOST.COM",
                        UserName = "admin@localhost.com",
                        Firstname = "System",
                        Lastname = "Admin",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true,
                    },
                    new Employee
                    {
                        Id = "73ad90b0-4238-44eb-9587-283f579e4764",
                        Email = "user@localhost.com",
                        NormalizedEmail = "User@LOCALHOST.COM",
                        NormalizedUserName = "User@LOCALHOST.COM",
                        UserName = "user@localhost.com",
                        Firstname = "System",
                        Lastname = "User",
                        PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                        EmailConfirmed = true,
                    }
                ) ;
        }
    }
}