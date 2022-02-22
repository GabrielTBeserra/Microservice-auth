using AUTH_SERVICE_DOMAIN.Entities.User;
using System.Threading.Tasks;

namespace AUTH_SERVICE_SERVICE.ApplicationService.Config.Interfaces
{
    public interface IBaseApplicationService
    {
        Task<UserEntity> GetLoggedUserUntracked();
        Task<UserEntity> GetLoggedUserTracked();
    }
}
