using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository
{
   public interface IPlayerModule
    {
        void Shoot(int goalKeeper, int attacker);
       // void AddToTeam(int IdPlayer, int IdTeam);
    }
}
