using Avanade.BestPratices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avanade.BestPratices.Infra.Data.Configurations
{
    public class ManufatureConfiguration : IEntityTypeConfiguration<Manufacture>
    {
        public void Configure(EntityTypeBuilder<Manufacture> builder)
        {
            builder.ToTable("Manufatures");
        }
    }
}
