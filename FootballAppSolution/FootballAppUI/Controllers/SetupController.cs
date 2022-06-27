using BusinessLogic;
using Common.Interfaces;
using FootballAppUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace FootballAppUI.Controllers
{
    public class SetupController : Controller
    {
        private ITeamService _teamService;
        private ILeagueService _leagueService;

        public SetupController(ITeamService teamService, ILeagueService leagueService)
        {
            _teamService = teamService;
            _leagueService = leagueService;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public ActionResult Teams()
        {
            List<TeamViewModel> teams = new List<TeamViewModel>();
            List<ITeam> storedTeams = _teamService.GetAllTeams();

            storedTeams.ForEach(st => teams.Add(new TeamViewModel()
            {
                Name = st.Name,
                Code = st.Code,
                HomeGround = st.HomeGround
            }));

            return View(teams);
        }

        [HttpGet]
        public ActionResult Leagues()
        {
            List<LeagueViewModel> leagues = new List<LeagueViewModel>();
            IEnumerable<ILeague> storedLeagues = _leagueService.GetAllLeagues();

            List<LeagueViewModel> viewModel = new List<LeagueViewModel>();
            storedLeagues.ToList().ForEach(sl => viewModel.Add(
                new LeagueViewModel()
                {
                    Name = sl.Name,
                    Founded = sl.Founded
                }));

            return View(viewModel);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateTeam(TeamViewModel team)
        {
            if (ModelState.IsValid)
            {
                await _teamService.AddTeam(team);
                return RedirectToAction("Teams");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CreateLeague(LeagueViewModel league)
        {
            if (ModelState.IsValid)
            {
                await _leagueService.AddLeagueAsync(league);
                return RedirectToAction("Leagues");
            }
            else
            {
                return View("Index");
            }
        }

        [HttpGet]
        public IActionResult IsCodeAvailable(string code)
        {
            return Json(_teamService.IsCodeAvailable(code));
        }

        [HttpGet]
        public IActionResult IsTeamNameAvailable(string name)
        {
            return Json(_teamService.IsTeamNameAvailable(name));
        }

        [HttpGet]
        public IActionResult GetTeamInputForm()
        {
            return PartialView("_TeamForm", new TeamViewModel());
        }

        [HttpGet]
        public IActionResult GetCreateLeagueForm()
        {
            return PartialView("_LeagueForm", new LeagueViewModel());
        }

        [HttpGet]
        public IActionResult Seasons()
        {
            return View();
        }
    }
}
