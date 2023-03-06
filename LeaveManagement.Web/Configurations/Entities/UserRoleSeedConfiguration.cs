using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "07acfdf7-6248-4e5a-9837-179cb857a150",
                    UserId = "01acfcf3-6145-4e3a-9565-169cb857a143"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "08acfdf8-6249-4e5a-9912-179cd857a152",
                    UserId = "02acfcf5-6430-4e3b-9497-169cb857a144"
                }
                );
        }
    }
}