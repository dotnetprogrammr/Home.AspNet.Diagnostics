
namespace WebApplication.AspNet5
{
    using System;

    using Microsoft.AspNet.Mvc;
    using Microsoft.Framework.DependencyInjection;

    /// <summary>
    /// Exposes methods that configure application dependencies.
    /// </summary>
    public partial class Startup
    {
        /// <summary>
        /// Configures the applications dependencies.
        /// </summary>
        public IServiceProvider ConfigureServices(IServiceCollection services)
        {
            services.AddMvc();

            services.Replace(new ServiceDescriptor(
                typeof(IControllerActivator), provider => new ControllerActivator(),
                 ServiceLifetime.Transient));

            return services.BuildServiceProvider();   
        }
    }
}