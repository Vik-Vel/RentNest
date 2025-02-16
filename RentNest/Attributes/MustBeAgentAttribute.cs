using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc;
using RentNest.Core.Contracts;
using System.Security.Claims;
using RentNest.Controllers;

namespace RentNest.Attributes
{
    public class MustBeAgentAttribute : ActionFilterAttribute
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

            // Checks If false (user is NOT an agent) → we enter if.
            if (agentService != null
                && agentService.ExistsByIdAsync(context.HttpContext.User.Id()).Result == false)
            {
                context.Result = new RedirectToActionResult(nameof(AgentController.Become), "Agent", null);
            }

        }
    }
}
