namespace FootballAppUI.Models
{
    public class SeasonViewModel
    {
        public IEnumerable<LeagueViewModel> Leagues { get; set; }
        public Dictionary<TeamViewModel, bool> SelectedTeams { get; set; }
    }
}
