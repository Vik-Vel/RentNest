using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using RentNest.Core.Contracts;
using RentNest.Models;
using System.Diagnostics;

namespace RentNest.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHouseService houseService;

        public HomeController(
            ILogger<HomeController> logger,
            IHouseService _houseService)
        {
            _logger = logger;
            houseService = _houseService;
        }

        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            var model = await houseService.LastThreeHousesAsync();

            return View(model);
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
