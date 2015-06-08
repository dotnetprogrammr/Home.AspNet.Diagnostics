namespace WebApplication.AspNet5
{
    using System.Threading.Tasks;

    using Microsoft.AspNet.Mvc;

    /// <summary>
    /// An MVC controller.
    /// </summary>
    public class HomeController : Controller
    {
        /// <summary>
        /// Exposes an endpoint that can be used to test connectivity.
        /// </summary>
        /// <returns>
        /// A <see cref="Task{T}"/> that represents the asynchronous opertion. The result of the task will be the 
        /// <see cref="string"/> content to return to the client.
        /// </returns>

        [HttpGet]
        [Route("connect")]
        public Task<string> GetStringValueAsync()
        {
            return Task.FromResult("Hello World.");
        }
    }
}