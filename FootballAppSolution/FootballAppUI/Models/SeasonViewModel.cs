using System.ComponentModel;

namespace FootballAppUI.Models
{
    public class SeasonViewModel
    {
        [DisplayName("Select a League")]
        public LeagueViewModel SelectedLeague { get; set; }
        public IEnumerable<LeagueViewModel> Leagues { get; set; }
        public Dictionary<TeamViewModel, bool> SelectedTeams { get; set; }
    }
}
