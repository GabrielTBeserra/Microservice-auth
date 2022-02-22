using AUTH_SERVICE_DOMAIN.Entities.User;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AUTH_SERVICE_INFRASTRUCTURE.Models.Mappers.User
{
    public class UserMapper : IEntityTypeConfiguration<UserEntity>
    {
        public void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.HasIndex(x => x.Email).IsUnique();
        }
    }
}
