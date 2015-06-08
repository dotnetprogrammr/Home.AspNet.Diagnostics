namespace WebApplication.AspNet5
{
    using System;

    using Microsoft.AspNet.Mvc;

    /// <summary>
    /// Provides methods to create a controller.
    /// </summary>
    public class ControllerActivator : IControllerActivator
    {
        /// <summary>
        /// Creates a controller.
        /// </summary>
        /// <param name="context">The <see cref="ActionContext"/> for the executing action.</param>
        public virtual object Create(ActionContext actionContext, Type controllerType)
        {
            if (controllerType == typeof(HomeController))
            {
                return new HomeController();
            }

            throw new InvalidOperationException(controllerType.ToString());
        }
    }
}