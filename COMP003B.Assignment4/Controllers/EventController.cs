using COMP003B.Assignment4.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Tracing;

namespace COMP003B.Assignment4.Controllers
{
    [Route("event")]
    public class EventController : Controller
    {
        [HttpGet("orderform/{product}")] 

        public IActionResult OrderForm(string product)
        {
            return View();
        }

        [HttpPost("orderform/{product}")]
        // Section checks to see if all required fields have been filled 
        // if not it returns back to the orderform view
        public IActionResult OrderForm([FromForm] OrderForm orderform)
        {
            if (!ModelState.IsValid)
            {
                return View(orderform);
            }

            return RedirectToAction("Success", orderform);
        }

        [Route("success")]

        public IActionResult Success(OrderForm orderform)
        {
            return View(orderform);
        }
    }

}
