using Autofac;
using Autofac.Integration.WebApi;
using System.Diagnostics.CodeAnalysis;
using System.Reflection;
using System.Web.Http;
using LuckyMasale.WebApi.Filters;

namespace LuckyMasale.WebApi
{
    /// <summary>
    /// Performs wiring of IoC container.
    /// </summary>
    [ExcludeFromCodeCoverage]
    internal class IocConfig
    {
        /// <summary>
        /// Configures Autofac for dependency injection.
        /// </summary>
        public static void ConfigureAutofac()
        {
            var builder = new ContainerBuilder();
            var config = GlobalConfiguration.Configuration;

            builder.RegisterAssemblyTypes(Assembly.Load("LuckyMasale.DAL"))
                .Where(t => t.Name.EndsWith("DataSource") || t.Name.EndsWith("Factory") || t.Name.EndsWith("DataProvider"))
                .AsImplementedInterfaces()
                .InstancePerRequest();

            builder.RegisterAssemblyTypes(Assembly.Load("LuckyMasale.BAL"))
                .Where(t => t.Name.EndsWith("Manager"))
                .AsImplementedInterfaces()
                .InstancePerRequest();

            builder.RegisterApiControllers(typeof(WebApiApplication).Assembly).PropertiesAutowired();

            config.DependencyResolver = new AutofacWebApiDependencyResolver(builder.Build());

            builder.RegisterWebApiFilterProvider(config);
        }
    }
}