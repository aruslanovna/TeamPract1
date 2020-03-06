
﻿using BLLayer.TeamService;
using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLLayer
{
   public class TeamModule:ITeam
    {
        Repository.ITeamModule _teamObj;
        public TeamModule()
        {
            _teamObj = Repository.Factory.GetTeamModuleObject();
        }
        public Team ChooseTeam(List<Team> players)
        {
            return _teamObj.ChooseTeam(players);
        }
        public void AddToTeam(int IdPlayer, int IdTeam)
        {
            _teamObj.AddToTeam(IdPlayer, IdTeam);
        }
        //public List<Team> ChooseTeams(List<Team> allTeams, List<Team> players)
        //{
        //    return _teamObj.ChooseTeams(allTeams,players);
        //}

        public List<Team> ChooseTeamsForGame()
        {
            return _teamObj.ChooseTeamsForGame();
        }

        public List<Team> GetList()
        {
            return _teamObj.GetList();
        }

        public Team GetTeamById(int Id)
        {
            return _teamObj.GetTeamById(Id);
        }

        //public Team RandomTeam()
        //{
        //    return _teamObj.RandomTeam();
        //}
    }
}