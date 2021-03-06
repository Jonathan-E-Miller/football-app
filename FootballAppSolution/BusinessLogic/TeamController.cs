using Common.Interfaces;
using Infastructure;
using Infastructure.Model;

namespace BusinessLogic
{
    public class TeamController : ITeamController
    {
        private ApplicationDbContext _applicationDbContext;

        public TeamController(ApplicationDbContext applicationDb) 
        {
            _applicationDbContext = applicationDb;
        }

        public List<IPlayer> Players { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public void AddPlayer(IPlayer player)
        {
            throw new NotImplementedException();
        }

        public async Task AddTeam(ITeam team)
        {
            if (team != null)
            {
                Team t = new Team()
                {
                    Name = team.Name,
                    Code = team.Code,
                    HomeGround = team.HomeGround,
                    Capacity = 40000
                };

                _applicationDbContext.Teams.Add(t);
                await _applicationDbContext.SaveChangesAsync();
            }

        }

        public void RemoveTeam(ITeam team)
        {
            if (_applicationDbContext != null)
            {
                Team? toRemove = _applicationDbContext.Teams.Where(t => t.Code == team.Code).FirstOrDefault();
                if (toRemove != null)
                {
                    _applicationDbContext.Remove(toRemove);
                    _applicationDbContext.SaveChangesAsync();
                }
            }
        }

        public List<ITeam> GetAllTeams()
        {
            List<ITeam> allTeams = new List<ITeam>();
            if (_applicationDbContext != null)
            {
                foreach (Team team in _applicationDbContext.Teams)
                {
                    allTeams.Add(team);
                }
            }

            return allTeams;
        }

        public bool IsCodeAvailable(string code)
        {
            bool available = true;
            if (_applicationDbContext.Teams.Any(t => t.Code == code))
            {
                available = false;
            }
            return available;
        }

        public bool IsTeamNameAvailable(string name)
        {
            bool available = true;
            if (_applicationDbContext.Teams.Any(t => t.Name == name))
            {
                available = false;
            }
            return available;
        }
    }
}