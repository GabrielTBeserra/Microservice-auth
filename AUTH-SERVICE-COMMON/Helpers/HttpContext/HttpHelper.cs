using AUTH_SERVICE_COMMON.Configurations.Http;

namespace AUTH_SERVICE_COMMON.Helpers.HttpContext
{
    public static class HttpHelper
    {
        public static string LoggedUser
        {
            get { return HttpContextGetter.ContextAcessor.HttpContext?.User.Identity.Name; }
        }
    }
}
