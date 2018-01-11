using System.Web;
using System.Web.Http;

namespace ChatMalta.Api
{
    public class WebApiApplication : HttpApplication
    {
        protected void Application_Start()
        {            
            GlobalConfiguration.Configure(WebApiConfig.Register);
            UnityConfig.RegisterComponents();
        }
    }
}