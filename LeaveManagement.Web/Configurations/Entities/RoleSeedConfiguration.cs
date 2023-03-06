using LeaveManagement.Web.Constants;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
            (
                new IdentityRole
                {
                    Id = "07acfdf7-6248-4e5a-9837-179cb857a150",
                    Name = Roles.Administrator,
                    NormalizedName= Roles.Administrator.ToUpper()
                    
                   
                },
                new IdentityRole
                {
                    Id = "08acfdf8-6249-4e5a-9912-179cd857a152",
                    Name = Roles.User,
                    NormalizedName = Roles.User.ToUpper()

                }
            );
        }
    }
}