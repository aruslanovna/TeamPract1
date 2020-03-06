
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

        readonly Repository.IPlayerModule _playerObj;
        public PlayerModule()
        {
            _playerObj = Repository.Factory.GetPlayerModuleObject();
        }


        //public void AddToTeam(int IdPlayer,int IdTeam)
        //{
        //    _playerObj.AddToTeam(IdPlayer,IdTeam);
        //}


       
        public void Shoot(int goalKeeper, int attacker)
        {
             _playerObj.Shoot(goalKeeper,attacker);

        }
    }
}