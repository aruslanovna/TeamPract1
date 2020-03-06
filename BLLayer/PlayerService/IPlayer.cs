
﻿using System;
using System.Collections.Generic;
using System.Text;
using Domain;
namespace BLLayer.PlayerService
{
   public interface IPlayer
    {
        void Shoot(int goalKeeper, int attacker);
        //  void AddToTeam(int IdPlayer, int IdTeam);
    }
}
