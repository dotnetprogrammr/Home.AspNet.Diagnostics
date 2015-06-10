
namespace Home.AspNet.Builder
{
    using System;
    using System.Threading.Tasks;

    using Microsoft.AspNet.Builder;
    using Microsoft.AspNet.Http;

    /// <summary>
    /// Captures synchronous and asynchronous exceptions from the pipeline and generates HTTP problem responses.
    /// </summary>
    public class HttpProblemMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly HttpProblemOptions _options;

        /// <summary>
        /// Initializes a new instance of the <see cref="HttpProblemMiddleware"/> class
        /// </summary>
        /// <param name="next"></param>
        /// <param name="options"></param>
        public HttpProblemMiddleware(RequestDelegate next, HttpProblemOptions options)
        {
            _next = next;
            _options = options;
        }

        /// <summary>
        /// Process an individual request.
        /// </summary>
        /// <param name="context"></param>
        /// <returns></returns>
        public async Task Invoke(HttpContext context)
        {
            try
            {
                await _next(context);
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}