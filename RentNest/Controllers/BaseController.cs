using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace RentNest.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
      
    }
}
