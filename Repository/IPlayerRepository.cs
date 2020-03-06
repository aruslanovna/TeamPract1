using Domain;

using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
    interface IPlayerRepository
    {
        
           IEnumerable<Player> GetPlayers();
           Player GetPlayer(int id);
        
    }
}
