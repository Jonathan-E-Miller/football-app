using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface ITeam
    {
        public string Name { get; set; }
        public string Code { get; set; }
        public string HomeGround { get; set; }
    }
}
