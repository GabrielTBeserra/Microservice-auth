using AUTH_SERVICE_DOMAIN.Entities.User;
using AUTH_SERVICE_INFRASTRUCTURE.Models;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.Config;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.User.Interfaces;

namespace AUTH_SERVICE_INFRASTRUCTURE.Repositories.User
{
    public class UserRepository : GenericRepository<UserEntity>, IUserRepository
    {
        public UserRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }
}
