using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Data.Migrations
{
    public partial class UpdatedRequestComments : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "2cf7c616-3e91-4a21-a065-8c426287bea7");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "2824cc02-d13b-44a2-9b90-04407eb9772c");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "4ff8bb33-ddf9-40b7-beb8-70d2bd17b89c", "AQAAAAEAACcQAAAAEODaE+SXZmnToQY7wlvA8qq0t8tkjgKoUxXn9wouazgBC/0YMn42dQmifLGKC0uBEw==", "c868af69-abb5-4d5b-ae03-980f5891b09b" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "32cd0517-abbb-44b1-80be-2880fb608c60", "AQAAAAEAACcQAAAAEG+TCExwcirC1ER4azQCo6ycDzHQD0VlByBwwGN+UEs28FvzY+7mQVqITJFMcABWRQ==", "eb725cc4-a481-4bfe-93d4-c00e5bfbef71" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "RequestComment",
                table: "LeaveRequests",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1234-7896-9587-283f579e4764",
                column: "ConcurrencyStamp",
                value: "25768bd6-3b87-4e64-8c1b-2259b0f57cb9");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "73ad90b0-1728-44eb-1995-283f579e4764",
                column: "ConcurrencyStamp",
                value: "31ac4082-ae24-4f91-a03f-d3d8e266f7f1");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "73ad90b0-4238-44eb-9587-283f579e4764",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "bbd76c5a-3e5b-41e9-aeb8-d3673aca0ee2", "AQAAAAEAACcQAAAAEO/q2jV/p4Emu6nTuZ9xcRZfOOr33AJv7RaV9Pbob0KUucf7/RwGu2OB+UCqo3rVBg==", "3f94a156-da1f-499c-a311-45e427419b4f" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "e18dc662-c956-45fc-a834-63128024ce27",
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "SecurityStamp" },
                values: new object[] { "33afc127-a278-49fd-b158-de44ee1aee28", "AQAAAAEAACcQAAAAECfjaOI5bTj/nhHXYICbuP2mrj8Z9oUjy2eX0fFsgKj8A4X+VuClhm34MDLbOALutQ==", "df4dca89-f6ad-4831-a9b3-3d28baa28793" });
        }
    }
}
