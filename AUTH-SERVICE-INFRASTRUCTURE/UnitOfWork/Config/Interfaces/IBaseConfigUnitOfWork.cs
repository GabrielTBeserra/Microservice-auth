using System.Threading.Tasks;

namespace AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Config.Interfaces
{
    public interface IBaseConfigUnitOfWork
    {
        Task CommitAsync();
    }
}
