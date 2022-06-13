using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface ILeague
    {
        public string Name { get; set; }
        public DateTime Founded { get; set; }
    }
}
