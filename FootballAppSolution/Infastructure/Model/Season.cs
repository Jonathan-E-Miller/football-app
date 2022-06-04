using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Model
{
    public class Season
    {
        public int Id { get; set; }
        public ICollection<Team> Teams { get; set; }

    }
}
