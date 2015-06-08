
namespace WebApplication.AspNet5
{   
    using Microsoft.AspNet.Builder;

    /// <summary>
    /// Exposes methods that configure the OWIN (Open Web Interface for .NET) pipeline.
    /// </summary>
    public partial class Startup
    {
        /// <summary>
        /// Configures the OWIN pipeline.
        /// </summary>
        public void Configure(IApplicationBuilder app)
        {
            // Add the error page into the pipeline.
            app.UseErrorPage();

            // Configure the pipeline with the MVC framework.
            app.UseMvc();

            // Integrate the welcome page into the pipeline.
            app.UseWelcomePage();
        }
    }
}