using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class RoleSeedConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData(
                new IdentityRole
                {
                    Id = "1982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                    Name = "User",
                    NormalizedName = "USER"
                },
                new IdentityRole
                {
                    Id = "0982cd2e-f56e-43ed-b8f0-96312b1c50fc",
                    Name = "Administrator",
                    NormalizedName = "ADMINISTRATOR"
                });
        }
    }
}
