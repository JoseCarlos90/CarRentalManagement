using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.AspNetCore.Identity;
using CarRentalManagement.Server.Models;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                {
                    RoleId = "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                    UserId = "1982cd2e-f56e-43ed-b8f0-96312b1c50fa"
                },
               new IdentityUserRole<string>
               {
                   RoleId = "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                   UserId = "1982cd2e-f56e-43ed-b8f0-96312b1c50fb"
               });
        }
    }
}
