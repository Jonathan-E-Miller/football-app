using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface ILeagueService
    {
        public Task AddLeagueAsync(ILeague league);
        public Task RemoveLeagueAsync(ILeague league);
        public bool IsLeagueNameAvailable(string name);
        public IEnumerable<ILeague> GetAllLeagues();
    }
}
