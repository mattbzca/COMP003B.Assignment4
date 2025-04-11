using Microsoft.AspNetCore.Mvc;
using COMP003B.Assignment4.Models;

namespace COMP003B.Assignment4.Controllers
{
    public class EventController : Controller
    {
        [HttpGet("event/register/{eventCode}")]
        public IActionResult Register([FromRoute] string eventCode)
        {
            var model = new TrailRegistration { EventCode = eventCode };
            return View(model);
        }

        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Register([FromForm] TrailRegistration model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }
            return RedirectToAction("Success", model);
        }

        [HttpGet]
        public IActionResult Success(TrailRegistration model)
        {
            return View(model);
        }
    }
}
