using Common.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace FootballAppUI.Models
{
    public class TeamViewModel : ITeam
    {

        [Display(Name = "Team")]
        [Required(ErrorMessage = "Team name is required")]
        [Remote("IsTeamNameAvailable", "Setup", ErrorMessage = "Team name already exists")]
        public string Name { get; set; }
        
        [Display(Name = "Venue")]
        public string HomeGround { get; set; }

        [Display(Name = "Code")]
        [Required(ErrorMessage = "Code is required")]
        [Remote("IsCodeAvailable", "Setup", ErrorMessage = "Code Already Exist.")]
        public string Code { get; set; }

        public TeamViewModel()
        {
            Name = string.Empty;
            HomeGround = string.Empty;
            Code = string.Empty;
        }

        public TeamViewModel(string name, string venueName, string code)
        {
            Name = name;
            HomeGround = venueName;
            Code = code;
        }    
    }
}
