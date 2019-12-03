using System.Web.Http;
using System.Web.Http.Cors;

namespace SistemaEmpresa
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var politicas = new EnableCorsAttribute(
                origins: "*",
                methods: "*",
                headers: "*"
                );
            config.EnableCors(politicas);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}
