using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurations.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "01acfcf3-6145-4e3a-9565-169cb857a143",
                    Email= "admin@gmail.com",
                    NormalizedEmail= "ADMIN@GMAIL.COM",
                    NormalizedUserName = "ADMIN@GMAIL.COM",
                    UserName = "admin@gmail.com",
                    Firstname= "System",
                    Lastname= "Admin",
                    PasswordHash = hasher.HashPassword(null,"@Admin1234"),
                    EmailConfirmed= true
                    
                },
                new Employee
                {
                    Id = "02acfcf5-6430-4e3b-9497-169cb857a144",
                    Email = "user@gmail.com",
                    NormalizedEmail = "USER@GMAIL.COM",
                    NormalizedUserName = "USER@GMAIL.COM",
                    UserName = "user@gmail.com",
                    Firstname = "System",
                    Lastname = "User",
                    PasswordHash = hasher.HashPassword(null,"@User1234"),
                    EmailConfirmed= true
                }
                );
        }
    }
}