using AUTH_SERVICE_COMMON.Helpers.HttpContext;

namespace AUTH_SERVICE_COMMON.Configurations.Service
{
    public abstract class BaseService
    {
        protected string LoggedUser
        {
            get { return HttpHelper.LoggedUser; }
        }
    }
}
