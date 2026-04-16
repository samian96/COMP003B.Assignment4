using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;
using System.Diagnostics.Tracing;

namespace COMP003B.Assignment4.Controllers
{
    [Route("context")]
    public class ContextController : Controller
    {
        [Route("index")]
        public IActionResult Index()
        {
            var context = new List<Context>
            {
                new Context {Id = 1, Title = "Graphic Design", Description = "Our graphic designers can turn your ideas into a reality." },

                new Context {Id = 2, Title = "Screen-Printing", Description = "Screen printing is the classic way to bring your brand to life!"},

                new Context {Id = 3, Title = "Digital Printing", Description = "Digital printing is the go to for small items and promotional swag."}
            };

            return View(context);
        }

        [Route("index2")]
        public IActionResult Index2()
        {
            var context = new List<Context>
            {
                new Context {Id = 1, Title = "This is a test title2", Description = "This is a test description" },

                new Context {Id = 2, Title = "Second test for a title", Description = "This is a test description"},

                new Context {Id = 3, Title = "Second test for a title", Description = "This is a test description"}
            };

            return View(context);
        }
        public IActionResult Context(int id)
        {
            var context = new Context { Id = id, Title = $"Context {id}", Description = "Detailed content coming soon" };
            return View(context);
        }
    }
}
