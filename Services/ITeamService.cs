using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Services
{
    public interface ITeamService
    {
        IEnumerable<Player> GetPlayers();
        Player GetPlayer(int id);
    }
}
