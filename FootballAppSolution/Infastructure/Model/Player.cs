using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Model
{
    public class Player
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Position { get; set; }
        public int NumberOfGoals { get; set; }
        public int NumberOfYellowCards { get; set; }
        public int NumberOfRedCards { get; set; }
        public Team CurrentTeam { get; set; }
    }
}
