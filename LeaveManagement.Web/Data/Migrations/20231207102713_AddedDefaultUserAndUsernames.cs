using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddedDefaultUserAndUsernames : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a81d417a-d5c4-4701-8b3e-218dd27786bf");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "af97d910-6adf-458c-9320-de6652d1aece");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "5791963f-8411-4064-ac7b-fd944e94a7b3", true, "User@LOCALHOST.COM", "AQAAAAEAACcQAAAAENJA9Q2l2YIu36lM6grzVi5YLAMO+f1BwH9hCev6pnNxO6cyCvmLWNp5wBhUyu9NYA==", "925d37d1-ecbb-4af5-9c9a-94df2ae210fc", "user@localhost.com" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "d499474a-a8f6-4ac4-a23e-84939e397bff", true, "ADMIN@LOCALHOST.COM", "AQAAAAEAACcQAAAAECmddoPNvbxTBf0iVG3vR41+2km2V2UotUqLm6AN7aMQOLgq0Ap9HSLSvPQLSUYPHA==", "819f6118-0f45-4cc1-bee9-249eeea07fd5", "admin@localhost.com" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "c52b9b67-42b9-4006-b67f-f2deb58b0351");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a13c04ed-bbc0-470b-8a0e-0eed0b4962a9");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "2480dca4-1994-41b6-9fcf-19a250c8d546", false, null, "AQAAAAEAACcQAAAAEKlEFOQ2ijUmIQn0Xp5zGGDkYZNARsjnCkb3lbBn9RUeJHeO2jCSEDwnWFNZbQ4Yug==", "6d1d7523-4eed-4b29-8d3d-cd8a71cbe0bc", null });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "EmailConfirmed", "NormalizedUserName", "PasswordHash", "SecurityStamp", "UserName" },
                values: new object[] { "33b7537a-1eba-427a-839a-e9464377d8de", false, null, "AQAAAAEAACcQAAAAEOu1wmka9K0GagCVwQYjUbQwCunly0U+Xiwkf9dagiOnwiBJC+boSwYZGFOH5WSC7Q==", "8e328e0c-889e-4807-aaed-dfe9513e91dd", null });
        }
    }
}
