using System.ComponentModel.DataAnnotations;

namespace FootballAppUI.Models
{
    public class TeamViewModel
    {

        [Display(Name = "Team")]
        [Required(ErrorMessage = "Team name is required")]
        public string Name { get; set; }
        
        [Display(Name = "Venue")]
        public string VenueName { get; set; }

        [Display(Name = "Code")]
        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        public TeamViewModel()
        {

        }

        public TeamViewModel(string name, string venueName, string code)
        {
            Name = name;
            VenueName = venueName;
            Code = code;
        }    
    }
}
