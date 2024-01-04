using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "73ad90b0-1234-7896-9587-283f579e4764", "c52b9b67-42b9-4006-b67f-f2deb58b0351", "User", "USER" },
                    { "73ad90b0-1728-44eb-1995-283f579e4764", "a13c04ed-bbc0-470b-8a0e-0eed0b4962a9", "Administrator", "ADMINISTRATOR" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxID", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "73ad90b0-4238-44eb-9587-283f579e4764", 0, "2480dca4-1994-41b6-9fcf-19a250c8d546", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@localhost.com", false, "System", "User", false, null, "User@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEKlEFOQ2ijUmIQn0Xp5zGGDkYZNARsjnCkb3lbBn9RUeJHeO2jCSEDwnWFNZbQ4Yug==", null, false, "6d1d7523-4eed-4b29-8d3d-cd8a71cbe0bc", null, false, null },
                    { "e18dc662-c956-45fc-a834-63128024ce27", 0, "33b7537a-1eba-427a-839a-e9464377d8de", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@localhost.com", false, "System", "Admin", false, null, "ADMIN@LOCALHOST.COM", null, "AQAAAAEAACcQAAAAEOu1wmka9K0GagCVwQYjUbQwCunly0U+Xiwkf9dagiOnwiBJC+boSwYZGFOH5WSC7Q==", null, false, "8e328e0c-889e-4807-aaed-dfe9513e91dd", null, false, null }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "73ad90b0-1234-7896-9587-283f579e4764", "73ad90b0-4238-44eb-9587-283f579e4764" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "73ad90b0-1728-44eb-1995-283f579e4764", "e18dc662-c956-45fc-a834-63128024ce27" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73ad90b0-1234-7896-9587-283f579e4764", "73ad90b0-4238-44eb-9587-283f579e4764" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "73ad90b0-1728-44eb-1995-283f579e4764", "e18dc662-c956-45fc-a834-63128024ce27" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27");
        }
    }
}
