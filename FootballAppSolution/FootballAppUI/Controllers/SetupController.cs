using BusinessLogic;
using Common.Interfaces;
using FootballAppUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballAppUI.Controllers
{
    public class SetupController : Controller
    {
        ITeamController _teamController;
        public SetupController(ITeamController controller)
        {
            _teamController = controller;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Teams()
        {
            List<TeamViewModel> teams = new List<TeamViewModel>();
            List<ITeam> storedTeams = _teamController.GetAllTeams();

            storedTeams.ForEach(st => teams.Add(new TeamViewModel()
            {
                Name = st.Name,
                Code = st.Code,
                HomeGround = st.HomeGround
            }));

            return View(teams);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateTeam(TeamViewModel team)
        {
            if (ModelState.IsValid)
            {
                await _teamController.AddTeam(team);
                return RedirectToAction("Teams");
            }
            else
            {
                return View("Index");
            }
        }
    }
}
