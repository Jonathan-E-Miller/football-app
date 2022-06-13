using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface IPlayer
    {
        public string PlayerForename { get; set; }
        public string PlayerSirname { get; set; }
        public ITeam Team { get; set; }
    }
}
