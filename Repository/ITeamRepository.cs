using Domain;
using System.Collections.Generic;

namespace Repository
{
    public interface ITeamRepository
    {
        
        IEnumerable<Player> GetPlayers();
        IEnumerable<Player> GetPlayersFromTeam(int Id);
        void AddtemToTeam(int IdTeam, int Idplayer);
        void DeleteFromTeam(int IdTeam, int Idplayer);
        Coach GetTeamCoach(int IdTeam);

        IList<string> Messages { get; set; }
        int PlayersInTeam { get; set; }
    }
}