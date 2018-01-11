using System.Web.Http;
using WebActivatorEx;
using ChatMalta.Api;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace ChatMalta.Api
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                  .EnableSwagger(c => c.SingleApiVersion("v1", "A title for your API"))
                    .EnableSwaggerUi();
        }
    }
}
