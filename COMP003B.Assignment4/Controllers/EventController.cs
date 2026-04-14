using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;

namespace COMP003B.Assignment4.Controllers
{
    [Route("event")]
    public class EventController : Controller
    {
        [HttpGet] 

        public IActionResult Register()
        {
            return View();
        }

    }
}
