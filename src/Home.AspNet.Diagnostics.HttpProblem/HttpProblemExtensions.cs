
namespace Home.AspNet.Builder
{
    using Microsoft.AspNet.Builder;

    /// <summary>
    /// IApplicationBuilder extension methods for the HttpProblemMiddleware.
    /// </summary>
    public static class HttpProblemExtensions
    {
        /// <summary>
        /// Captures synchronous and asynchronous exceptions from the pipeline and generates HTTP problem responses.
        /// Full error details are only returned by default if 'host.AppMode' is set to 'development' in the IApplicationBuilder.Properties.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="baseUriString"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseProblemResponse(this IApplicationBuilder builder, string baseUriString)
        {
            return builder.UseProblemResponse(new HttpProblemOptions(baseUriString));
        }

        /// <summary>
        /// Captures synchronous and asynchronous exceptions from the pipeline and generates HTTP problem responses.
        /// Full error details are only returned by default if 'host.AppMode' is set to 'development' in the IApplicationBuilder.Properties.
        /// </summary>
        /// <param name="builder"></param>
        /// <param name="options"></param>
        /// <returns></returns>
        public static IApplicationBuilder UseProblemResponse(this IApplicationBuilder builder, HttpProblemOptions options)
        {
            return builder;
        }
    }
}