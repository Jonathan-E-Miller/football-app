using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Model
{
    public class Round
    {
        public int Id { get; set; }
        public DateTime StartDate { get; set; }

        public ICollection<Match> Matches { get; set; }

        public int SeasonId { get; set; }
        public Season Season { get; set; }

        public Round()
        {
            Matches = new List<Match>();
        }
    }
}
