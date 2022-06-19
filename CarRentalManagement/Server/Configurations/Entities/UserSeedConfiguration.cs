using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;
using CarRentalManagement.Server.Models;

namespace CarRentalManagement.Server.Configurations.Entities
{

    public class UserSeedConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {
            var hasher = new PasswordHasher<ApplicationUser>();
            builder.HasData(
                new ApplicationUser
                {
                    Id = "1982cd2e-f56e-43ed-b8f0-96312b1c50fa",
                    Email = "josecarlos@test.com",
                    FirstName = "José Carlos",
                    LastName = "González",
                    NormalizedEmail = "JOSECARLOS@TEST.COM",
                    NormalizedUserName = "JOSECARLOS@TEST.COM",
                    PasswordHash = hasher.HashPassword(null, "P@assword1")
                },
               new ApplicationUser
               {
                   Id = "1982cd2e-f56e-43ed-b8f0-96312b1c50fb",
                   Email = "Admin@test.com",
                   FirstName = "Admin",
                   LastName = "",
                   NormalizedEmail = "ADMININISTRATOR@TEST.COM",
                   NormalizedUserName = "ADMININISTRATOR@TEST.COM",
                   PasswordHash = hasher.HashPassword(null, "P@assword1")
               });
        }
    }
}
