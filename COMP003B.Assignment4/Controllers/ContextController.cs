using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;
using System.Diagnostics.Tracing;
using System.Reflection;

namespace COMP003B.Assignment4.Controllers
{
    [Route("context")]
    public class ContextController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            var summary = new List<Summary>
            {
                new Summary {Id = 1, Title = "Graphic Design", Description = "Our graphic designers can turn your ideas into a reality." },

                new Summary {Id = 2, Title = "Screen-Printing", Description = "Screen printing is the classic way to bring your brand to life!"},

                new Summary {Id = 3, Title = "Digital Printing", Description = "Digital printing is the go to for small items and promotional swag."}
            };

            return View(summary);
        }

        [Route("index2")]
        public IActionResult Index2()
        {
            var details = new List<Summary>
            {
                new Summary {Id = 1, Title = "Performance", Description = "When you are looking for performance, A4 is the way to go." },

                new Summary {Id = 2, Title = "Comfort", Description = "Next Level brand is the perfect choice for comfortable and sturdy streetwear."},

                new Summary {Id = 3, Title = "Looking for more?", Description = "Check out our distributers website for a full catalog!"}
            };

            return View(details);
        }
        public IActionResult Summary(int id)
        {
            var details = new Summary { Id = id, Title = $"Summary {id}", Description = "This area would be the description of the content clicked. Currently Under construction." };
            return View(details);
        }
    }
}
