using AUTH_SERVICE_DOMAIN.Entities.User;

namespace AUTH_SERVICE_SERVICE.ApplicationService.Config.Interfaces
{
    public interface ITokenApplicationService
    {
        string GenerateToken(UserEntity user);
    }
}
