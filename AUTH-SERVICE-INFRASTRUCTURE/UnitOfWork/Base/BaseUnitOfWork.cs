using AUTH_SERVICE_INFRASTRUCTURE.Models;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.User.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Base.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Config;

namespace AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Base
{
    public class BaseUnitOfWork : BaseConfigUnitOfWork, IBaseUnitOfWork
    {
        public BaseUnitOfWork(ApplicationDbContext applicationDbContext, IUserRepository userRepository) : base(applicationDbContext)
        {
            UserRepository = userRepository;
        }

        public IUserRepository UserRepository { get; }
    }
}
