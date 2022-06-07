using Common.Interfaces;
using System.ComponentModel.DataAnnotations;

namespace FootballAppUI.Models
{
    public class TeamViewModel : ITeam
    {

        [Display(Name = "Team")]
        [Required(ErrorMessage = "Team name is required")]
        public string Name { get; set; }
        
        [Display(Name = "Venue")]
        public string HomeGround { get; set; }

        [Display(Name = "Code")]
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        public TeamViewModel()
        {

        }

        public TeamViewModel(string name, string venueName, string code)
        {
            Name = name;
            HomeGround = venueName;
            Code = code;
        }    
    }
}
