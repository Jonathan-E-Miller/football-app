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
        private Season? _season;
        public Season Season
        {
            set => _season = value;
            get => _season
                   ?? throw new InvalidOperationException("Uninitialized property: " + nameof(Season));
        }

        public Round()
        {
            Matches = new List<Match>();
        }
    }
}
