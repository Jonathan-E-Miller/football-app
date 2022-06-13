using Common.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Model
{
    /// <summary>
    /// High level information about a league.
    /// </summary>
    public class League : ILeague
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public DateTime Founded { get; set; }

        public League(string name)
        {
            Name = name;
        }
    }
}
