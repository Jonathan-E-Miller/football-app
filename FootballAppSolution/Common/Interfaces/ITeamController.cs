using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Interfaces
{
    public interface ITeamService
    {
        public List<IPlayer> Players { get; set; }
        public Task AddTeam(ITeam team);
        public void RemoveTeam(ITeam team);
        public void AddPlayer(IPlayer player);

        public bool IsCodeAvailable(string code);
        public bool IsTeamNameAvailable(string name);

        public List<ITeam> GetAllTeams();
    }
}
