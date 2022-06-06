using FootballAppUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballAppUI.Controllers
{
    public class SetupController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Teams()
        {
            return View();
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTeam(TeamViewModel team)
        {
            if (ModelState.IsValid)
            {
                return new StatusCodeResult(StatusCodes.Status200OK);
            }
            else
            {
                return View("Index");
            }
        }
    }
}
