using Common.Interfaces;
using Infastructure;
using Infastructure.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLogic
{
    public class LeagueService : ILeagueService
    {
        private ApplicationDbContext _applicationDbContext;

        public LeagueService(ApplicationDbContext databaseContext)
        {
            _applicationDbContext = databaseContext;
        }

        public async Task AddLeagueAsync(ILeague league)
        {
            League dbLeague = new League(league.Name)
            {
                Founded = league.Founded
            };

            _applicationDbContext.Add(dbLeague);
            await _applicationDbContext.SaveChangesAsync();
        }

        public bool IsLeagueNameAvailable(string name)
        {
            return _applicationDbContext.Teams.Any(t => t.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        }

        public async Task RemoveLeagueAsync(ILeague league)
        {
            _applicationDbContext.Remove(league);
            await _applicationDbContext.SaveChangesAsync();
        }

        public IEnumerable<ILeague> GetAllLeagues()
        {
            List<League> dbLeagues = _applicationDbContext.Leagues.ToList();

            return dbLeagues;

            
        }
    }
}
