using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Controllers
{
    public class ContextController : Controller
    {
    public IActionResult Context()
        {
            var context = new List<Context>
            {
                new Context {Id = 1, Title = "This is a test title", Description = "This is a test description" }
            };

            return View(context);
        }
    }
}
