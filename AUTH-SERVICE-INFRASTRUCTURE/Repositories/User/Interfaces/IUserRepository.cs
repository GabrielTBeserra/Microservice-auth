using AUTH_SERVICE_DOMAIN.Entities.User;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.Config.Interfaces;

namespace AUTH_SERVICE_INFRASTRUCTURE.Repositories.User.Interfaces
{
    public interface IUserRepository : IGenericRepository<UserEntity>
    {
    }
}
