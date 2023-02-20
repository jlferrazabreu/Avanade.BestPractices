using Avanade.BestPratices.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Avanade.BestPratices.Infra.Data.Configurations
{
    public class DocumentParameterConfiguration : IEntityTypeConfiguration<DocumentParameter>
    {
        public void Configure(EntityTypeBuilder<DocumentParameter> builder)
        {
            builder.ToTable("DocumentsParameter");
        }
    }
}
