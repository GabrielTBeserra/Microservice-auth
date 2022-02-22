using AUTH_SERVICE_INFRASTRUCTURE.Repositories.Audit.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.User.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Config.Interfaces;

namespace AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.User.Interfaces
{
    public interface IAuthUnitOfWork : IBaseConfigUnitOfWork
    {
        IUserRepository UserRepository { get; }
        ILogRepository LogRepository { get; }
    }
}
