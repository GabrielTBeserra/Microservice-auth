using AUTH_SERVICE_DOMAIN.Entities.Audit;
using AUTH_SERVICE_INFRASTRUCTURE.Models;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.Audit.Interfaces;
using AUTH_SERVICE_INFRASTRUCTURE.Repositories.Config;

namespace AUTH_SERVICE_INFRASTRUCTURE.Repositories.Audit
{
    public class LogRepository : GenericRepository<LogEntity>, ILogRepository
    {
        public LogRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
        }
    }


}
