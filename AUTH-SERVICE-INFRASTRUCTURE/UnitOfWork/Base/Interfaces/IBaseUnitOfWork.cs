using AUTH_SERVICE_INFRASTRUCTURE.Repositories.User.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Config.Interfaces;

namespace AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Base.Interfaces
{
    public interface IBaseUnitOfWork : IBaseConfigUnitOfWork
    {
        IUserRepository UserRepository { get; }
    }
}
