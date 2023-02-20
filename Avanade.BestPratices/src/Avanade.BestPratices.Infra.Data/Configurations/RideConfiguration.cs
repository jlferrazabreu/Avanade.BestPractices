using Avanade.BestPratices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avanade.BestPratices.Infra.Data.Configurations
{
    public class RideConfiguration : IEntityTypeConfiguration<Ride>
    {
        public void Configure(EntityTypeBuilder<Ride> builder)
        {
            builder.ToTable("Rides");
        }
    }
}
