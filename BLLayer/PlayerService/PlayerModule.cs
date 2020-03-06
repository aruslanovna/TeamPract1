
﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using Repository;

namespace BLLayer.PlayerService
{
   public class PlayerModule:IPlayer
    {

         Repository.IPlayerModule _playerObj;
        public PlayerModule()
        {
            _playerObj = Factory.GetPlayerModuleObject();
        }


        //public void AddToTeam(int IdPlayer,int IdTeam)
        //{
        //    _playerObj.AddToTeam(IdPlayer,IdTeam);
        //}


        List<Team> team = new List<Team>();
        public void Shoot(int goalKeeper, int attacker)
        {
             _playerObj.Shoot(goalKeeper,attacker);

        }
    }
}