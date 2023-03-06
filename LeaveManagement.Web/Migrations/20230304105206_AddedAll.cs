using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace LeaveManagement.Web.Migrations
{
    public partial class AddedAll : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "07acfdf7-6248-4e5a-9837-179cb857a150", "94b8c1a3-9dcb-4809-8ac7-81aeae0c802d", "Administrator", "ADMINISTRATOR" },
                    { "08acfdf8-6249-4e5a-9912-179cd857a152", "44d2a615-a205-4dd7-8ae7-7fc0f7ce4885", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "DateJoined", "DateOfBirth", "Email", "EmailConfirmed", "Firstname", "Lastname", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TaxId", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { "01acfcf3-6145-4e3a-9565-169cb857a143", 0, "9b64361d-af08-4368-8610-8fe976f0c766", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "admin@gmail.com", true, "System", "Admin", false, null, "ADMIN@GMAIL.COM", null, "AQAAAAEAACcQAAAAEHa8ZYoD3qA8qpxnL8V836yEV16RXIYdgxGkaEuO1kjjuxBi05sZpfeB+3NVCcphjw==", null, false, "20579944-d37b-4f6b-bc20-a76e7153a07c", null, false, "admin@gmail.com" },
                    { "02acfcf5-6430-4e3b-9497-169cb857a144", 0, "73b4413e-ec1c-4d68-8bb9-50e091c2c6bf", new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "user@gmail.com", true, "System", "User", false, null, "USER@GMAIL.COM", null, "AQAAAAEAACcQAAAAEGtD0iiEpktmHB2zDn+kereQz+JbR4u/jf9vPBM1jzq8EE47VfVtts4eumnRDHX32w==", null, false, "5a07ab3c-8f4c-4be4-a921-4b9a8d6cfa43", null, false, "user@gmail.com" }
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
    }
}
