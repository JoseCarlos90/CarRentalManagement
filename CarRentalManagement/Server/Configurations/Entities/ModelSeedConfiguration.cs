using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configurations.Entities
{
    public class ModelSeedConfiguration : IEntityTypeConfiguration<Model>
    {
        public void Configure(EntityTypeBuilder<Model> builder)
        {
            builder.HasData(
                new Model
                {
                    Id = 1,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "A5",
                    UpdatedBy = "System",
                },
                new Model
                {
                    Id = 2,
                    CreatedBy = "System",
                    DateCreated = DateTime.Now,
                    DateUpdated = DateTime.Now,
                    Name = "Model 3",
                    UpdatedBy = "System",
                });
        }
    }
}