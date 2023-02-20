using Avanade.BestPratices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avanade.BestPratices.Infra.Data.Configurations
{
    public class ModelVersionConfiguration : IEntityTypeConfiguration<ModelVersion>
    {
        public void Configure(EntityTypeBuilder<ModelVersion> builder)
        {
            builder.ToTable("ModelsVersion");
        }
    }
}
