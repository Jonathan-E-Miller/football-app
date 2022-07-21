using Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace FootballAppUI.Models
{
    public class LeagueViewModel : ILeague
    {
        [Display(Name = "League Title")]
        [Required(ErrorMessage = "A league title is required")]
        public string Name { get; set; }
        
        [Display(Name = "Founded date")]
        public DateTime Founded { get; set; }

        public override string ToString()
        {
            return Name;
        }
    }
}
