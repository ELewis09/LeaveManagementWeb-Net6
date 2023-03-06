using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class AddNormalizeUserNAme : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07acfdf7-6248-4e5a-9837-179cb857a150",
                column: "ConcurrencyStamp",
                value: "7fab0571-e7fe-4aed-8b0e-fdaef2ef690c");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08acfdf8-6249-4e5a-9912-179cd857a152",
                column: "ConcurrencyStamp",
                value: "bb84cbcc-e577-4d73-9ebb-57176f5ee4a3");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01acfcf3-6145-4e3a-9565-169cb857a143",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "316cf4da-89d5-4db2-a74d-858c97e69b7c", "ADMIN@GMAIL.COM", "AQAAAAEAACcQAAAAEKdR7R+iJf7HK0W7FVv94agr+wwHd2SM/QuGdsGRy1xYPP2PkECt0TPP1YxMWP+Mhg==", "886d48cf-8e93-404d-9427-5cb4d5dc8e66" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02acfcf5-6430-4e3b-9497-169cb857a144",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "c007a70f-01a8-45f4-b2bb-f32a95e314e7", "USER@GMAIL.COM", "AQAAAAEAACcQAAAAEA40zM3wMD6ebGlR97brmsLht/tXRoXjoYSSzuzEx/LwBD0sgfoTjw8rkyX+ji4I6A==", "3f44d128-b0b8-49e2-a360-681d7c6ae8f5" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07acfdf7-6248-4e5a-9837-179cb857a150",
                column: "ConcurrencyStamp",
                value: "d114c17f-c642-4b9b-b9cb-2f252d2c4360");

            migrationBuilder.UpdateData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08acfdf8-6249-4e5a-9912-179cd857a152",
                column: "ConcurrencyStamp",
                value: "b2bb576b-abe2-4cd1-81a1-d0ec4fdc9990");

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01acfcf3-6145-4e3a-9565-169cb857a143",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "69157ce6-4e29-41f0-a636-4bf4e671c549", null, "AQAAAAEAACcQAAAAEFmJuvu419IrTTg9VeWb6Rtwt7BB0KdL5bB8J/qpl1vTLq2BvuCog7MzmBmE0SdVwg==", "3de5448c-d2a3-4a79-ae90-01fed1b82989" });

            migrationBuilder.UpdateData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02acfcf5-6430-4e3b-9497-169cb857a144",
                columns: new[] { "ConcurrencyStamp", "NormalizedUserName", "PasswordHash", "SecurityStamp" },
                values: new object[] { "b1b9a293-a1fa-4747-86d8-cecb1465d939", null, "AQAAAAEAACcQAAAAEKPerurZOZKJJXl3XLSFgRRLnvnJbWIBuP2jqZ4kml1yXy/UooUbkUA8XszMAx1urQ==", "157e2fd6-733b-4792-87cc-23c7c4be88c1" });
        }
    }
}
