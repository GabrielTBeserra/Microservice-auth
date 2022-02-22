using AUTH_SERVICE_DOMAIN.Entities.Audit;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace AUTH_SERVICE_INFRASTRUCTURE.Models.Mappers.User
{
    public class AuditMapper : IEntityTypeConfiguration<LogEntity>
    {
        public void Configure(EntityTypeBuilder<LogEntity> builder)
        {
            builder.Property(x => x.LogTime)
                   .HasColumnType("datetime")
                   .HasDefaultValue(DateTime.Now);

            builder.Property(x => x.Id)
                   .HasColumnType("varchar(36)");
        }
    }
}
