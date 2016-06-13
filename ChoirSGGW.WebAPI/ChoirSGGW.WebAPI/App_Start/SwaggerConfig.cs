using System.Web.Http;
using WebActivatorEx;
using ChoirSGGW.WebAPI;
using Swashbuckle.Application;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace ChoirSGGW.WebAPI
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            GlobalConfiguration.Configuration
                .EnableSwagger(c => c.SingleApiVersion("v1", "Choir SGGW Documentation"))
                .EnableSwaggerUi();
        }
    }
}
