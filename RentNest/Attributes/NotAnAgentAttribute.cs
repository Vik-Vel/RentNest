using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using RentNest.Core.Contracts;
using System.Security.Claims;

namespace RentNest.Attributes
{
    //NotAnAgentAttribute inherits ActionFilterAttribute, which means it can be used as an attribute ([NotAnAgent]) on a controller or method.
    public class NotAnAgentAttribute : ActionFilterAttribute
    {
        //OnActionExecuting is executed before the action (Action) in the controller.
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            //Calls base.OnActionExecuting(context) to implement the default behavior of ActionFilterAttribute.
            base.OnActionExecuting(context);

            IAgentService? agentService = context.HttpContext.RequestServices.GetService<IAgentService>();

            //Checks if IAgentService exists
            if (agentService == null)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status500InternalServerError);
            }

            // Checks if the user is an agent
            if (agentService != null 
                && agentService.ExistsByIdAsync(context.HttpContext.User.Id()).Result)
            {
                context.Result = new StatusCodeResult(StatusCodes.Status400BadRequest);
            }

        }
    }
}
