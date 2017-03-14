using Newtonsoft.Json.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Net.Http.Formatting;
using System.Web.Http;

namespace LuckyMasale.WebApi
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            // Web API configuration and services
            // Configure Web API to use only bearer token authentication.

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{action}/{id}",
                defaults: new { controller = "User", action = "GetAllUsers", id = RouteParameter.Optional }
            );

            // Get the default json formatter 
            var jsonFormatter = config.Formatters.OfType<JsonMediaTypeFormatter>().First();

            // Switch from PascalCase to CamelCase
            jsonFormatter.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver();
        }
    }
}
