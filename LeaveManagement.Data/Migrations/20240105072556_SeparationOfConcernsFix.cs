using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Data.Migrations
{
    public partial class SeparationOfConcernsFix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "6d7367c2-9167-4d28-82fb-a0c99442a73d");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "e0243fda-4875-48e7-b26a-99cd371f1920");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "796860e8-5706-43a0-ba0c-487cf07d8225", "AQAAAAEAACcQAAAAEAD7myCB6UONZlC/Z8NL/DmukdPCXxV6IAd1m936bpbHnxFs4SNkEHJ2SwfBrasMlw==", "929361ab-e46a-439f-90ac-79fd90814fb0" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "04185f12-bff7-410f-af20-6dd93bc3a717", "AQAAAAEAACcQAAAAEBig/e+TmSQ9RHPZeGAbRKzuTqbuLv5r0rZHuHpUlKlzQOBQOd5hAXOPw/caOmNJsA==", "3dee7833-6de6-4d58-9dcc-983c2d195841" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "a0872baa-daff-456e-bfaf-ff6df7f466b8");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "3a5e8c70-915d-4b27-b01e-4af62cfc38de");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "99be8e27-1dfc-4791-98e8-0d5bd2f70174", "AQAAAAEAACcQAAAAEGejBXJIoGyGiufnilE/QCghaMA9Y1pd+BOOKYWhsleS9XhedbtDflHXQzt9t/a49Q==", "1b7c7530-126a-4229-89a3-e3990503ee0b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4d101a57-ae8e-4775-bac3-6245d4174d55", "AQAAAAEAACcQAAAAEMOTbhuhECSHWaltWXpbAhcmUkloGB4NRsUxavXFYx11SEecILXjklPfIQWgYF619A==", "1701749c-28d0-4357-a1a5-904637a9ff7f" });
        }
    }
}
