using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Model
{
    public class Team
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string HomeGround { get; set; }
        public int Capacity { get; set; }

        public ICollection<Match> HomeMatches { get; set; }
        public ICollection<Match> AwayMatches { get; set; }
    }
}
