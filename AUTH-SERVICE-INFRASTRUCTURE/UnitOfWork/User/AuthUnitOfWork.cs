using AUTH_SERVICE_INFRASTRUCTURE.Models;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.Audit.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.User.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Config;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.User.Interfaces;

namespace AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.User
{
    public class AuthUnitOfWork : BaseConfigUnitOfWork, IAuthUnitOfWork
    {
        public AuthUnitOfWork(ApplicationDbContext applicationDbContext , IUserRepository userRepository , ILogRepository logRepository) : base(applicationDbContext)
        {
            UserRepository = userRepository;
            LogRepository = logRepository;
        }

        public IUserRepository UserRepository { get; }

        public ILogRepository LogRepository { get; }

    }
}
