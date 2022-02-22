using AUTH_SERVICE_COMMON.Exceptions;
using AUTH_SERVICE_COMMON.Helpers.HttpContext;
using AUTH_SERVICE_DOMAIN.Entities.User;
using AUTH_SERVICE_INFRASTRUCTURE.UnitOfWork.Base.Interfaces;
using AUTH_SERVICE_SERVICE.ApplicationService.Config.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;

namespace AUTH_SERVICE_SERVICE.ApplicationService.Config
{
    public class BaseApplicationService : IBaseApplicationService
    {
        protected readonly IBaseUnitOfWork BaseUnitOfWork;

        public BaseApplicationService(IBaseUnitOfWork unitOfWork)
        {
            BaseUnitOfWork = unitOfWork;
        }

        public async Task<UserEntity> GetLoggedUserTracked()
        {
            var loggedUserName = HttpHelper.LoggedUser;
            var user = await BaseUnitOfWork.UserRepository.GetTracked().Where(x => x.Email == loggedUserName).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new DomainException("User not found");
            }

            return user;
        }


        public async Task<UserEntity> GetLoggedUserUntracked()
        {
            var loggedUserName = HttpHelper.LoggedUser;
            var user = await BaseUnitOfWork.UserRepository.GetTracked().Where(x => x.Email == loggedUserName).FirstOrDefaultAsync();

            if (user == null)
            {
                throw new DomainException("User not found");
            }

            return user;
        }


    }
}
