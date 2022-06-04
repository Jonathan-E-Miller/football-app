using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Model
{
    public class Match
    {
        public int Id { get; set; }
        public DateTime KickOff { get; set; }
        [ForeignKey("Team")]
        public int HomeTeamId { get; set; }
        public Team HomeTeam { get; set; }
        [ForeignKey("Team")]
        public int AwayTeamId { get; set; }
        public Team AwayTeam { get; set; }
        public int HomeGoals { get; set; }
        public int AwayGoals { get; set; }
    }
}
