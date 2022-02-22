using AUTH_SERVICE_DOMAIN.Entities.Audit;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.Config.Interfaces;

namespace AUTH_SERVICE_INFRASTRUCTURE.Repositories.Audit.Interfaces
{
    public interface ILogRepository : IGenericRepository<LogEntity>
    {
    }


}
