using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class AddedAllRoles : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07acfdf7-6248-4e5a-9837-179cb857a150", "d114c17f-c642-4b9b-b9cb-2f252d2c4360", "Administrator", "ADMINISTRATOR" },
                    { "08acfdf8-6249-4e5a-9912-179cd857a152", "b2bb576b-abe2-4cd1-81a1-d0ec4fdc9990", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01acfcf3-6145-4e3a-9565-169cb857a143", 0, "69157ce6-4e29-41f0-a636-4bf4e671c549", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "System", "Admin", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEFmJuvu419IrTTg9VeWb6Rtwt7BB0KdL5bB8J/qpl1vTLq2BvuCog7MzmBmE0SdVwg==", null, false, "3de5448c-d2a3-4a79-ae90-01fed1b82989", null, false, "admin@gmail.com" },
                    { "02acfcf5-6430-4e3b-9497-169cb857a144", 0, "b1b9a293-a1fa-4747-86d8-cecb1465d939", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "System", "User", false, null, "USER@GMAIL.COM", null, "AQAAAAEAACcQAAAAEKPerurZOZKJJXl3XLSFgRRLnvnJbWIBuP2jqZ4kml1yXy/UooUbkUA8XszMAx1urQ==", null, false, "157e2fd6-733b-4792-87cc-23c7c4be88c1", null, false, "user@gmail.com" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "07acfdf7-6248-4e5a-9837-179cb857a150", "01acfcf3-6145-4e3a-9565-169cb857a143" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "08acfdf8-6249-4e5a-9912-179cd857a152", "02acfcf5-6430-4e3b-9497-169cb857a144" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "07acfdf7-6248-4e5a-9837-179cb857a150", "01acfcf3-6145-4e3a-9565-169cb857a143" });

            migrationBuilder.DeleteData(
                table: "AspNetUserRoles",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { "08acfdf8-6249-4e5a-9912-179cd857a152", "02acfcf5-6430-4e3b-9497-169cb857a144" });

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "07acfdf7-6248-4e5a-9837-179cb857a150");

            migrationBuilder.DeleteData(
                table: "AspNetRoles",
                keyColumn: "Id",
                keyValue: "08acfdf8-6249-4e5a-9912-179cd857a152");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "01acfcf3-6145-4e3a-9565-169cb857a143");

            migrationBuilder.DeleteData(
                table: "AspNetUsers",
                keyColumn: "Id",
                keyValue: "02acfcf5-6430-4e3b-9497-169cb857a144");
        }
    }
}
