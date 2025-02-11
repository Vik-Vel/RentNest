using Microsoft.AspNetCore.Mvc;
using RentNest.Core.Contracts;
using RentNest.Core.Models.Agent;
using System.Security.Claims;

namespace RentNest.Controllers
{
    public class AgentController : BaseController
    {
        private readonly IAgentService agentService;

        public AgentController(IAgentService _agentService)
        {
            agentService = _agentService;
        }
        [HttpGet]
        public async Task<IActionResult> Become()
        {
            if (await agentService.ExistByIdAsync(User.Id()))
            {
                return BadRequest();
            }
            var model = new BecomeAgentFormModel();
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Become(BecomeAgentFormModel model)
        {

            return RedirectToAction(nameof(HouseController.All), "House");
        }
    }
}
