using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class AddPeriodAllocation : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Period",
                table: "LeaveAllocations",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "37543a59-25f7-4c49-9201-a50852aa2f44");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "4417d91c-3ec1-46a5-b7c7-c0f0c654e38b");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "592a89b8-8055-458d-918c-70634cf94b41", "AQAAAAEAACcQAAAAEB+/19aZgh5YYl5DY66bXHUv+KOj/xJBVGxdsBkfmBi59GTbThl1HcoTjvrTarlzgA==", "5c3c435e-d33a-4aaa-9140-40ec6a2d4a73" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d905cd78-1b83-40dd-b6a6-9fe6fac0f6e1", "AQAAAAEAACcQAAAAEBIq3ZAKRCTCvJeOux1VpfcZ68UVVF5ha3TA77bMjpdkBNOdn5Ur55D9jJ7IgfbE3A==", "fe230432-9ba1-495a-a008-88822dc3d9f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Period",
                table: "LeaveAllocations");

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
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "5791963f-8411-4064-ac7b-fd944e94a7b3", "AQAAAAEAACcQAAAAENJA9Q2l2YIu36lM6grzVi5YLAMO+f1BwH9hCev6pnNxO6cyCvmLWNp5wBhUyu9NYA==", "925d37d1-ecbb-4af5-9c9a-94df2ae210fc" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "d499474a-a8f6-4ac4-a23e-84939e397bff", "AQAAAAEAACcQAAAAECmddoPNvbxTBf0iVG3vR41+2km2V2UotUqLm6AN7aMQOLgq0Ap9HSLSvPQLSUYPHA==", "819f6118-0f45-4cc1-bee9-249eeea07fd5" });
        }
    }
}
