using FootballAppUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballAppUI.Controllers
{
    public class SetupController : Controller
    {
        List<TeamViewModel> teams = new List<TeamViewModel>()
            {
                new TeamViewModel() {Name="Huddersfield Town", Code = "HUD", VenueName="John Smiths Stadium"},
                new TeamViewModel() {Name="Leeds United", Code = "LEE", VenueName="Elland Road"},
                new TeamViewModel() {Name="Sheffield Wednesday", Code = "WED", VenueName="Hillsborough"}
            };
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Teams()
        {
          
            return View(teams);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateTeam(TeamViewModel team)
        {
            if (ModelState.IsValid)
            {
                teams.Add(team);
                return View("Teams", teams);
            }
            else
            {
                return View("Index");
            }
        }
    }
}
