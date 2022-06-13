using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Model
{
    /// <summary>
    /// A run of fixtures for a specific league.
    /// </summary>
    public class Season
    {
        public int Id { get; set; }
        public int LeagueId { get; set; }
        public League League { get; set; }

        public ICollection<Team> Teams { get; set; }
        public ICollection<Round> Rounds { get; set; }

        public Season()
        {
            Teams = new List<Team>();
        }
        

    }
}
