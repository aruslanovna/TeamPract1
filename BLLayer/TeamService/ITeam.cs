
﻿using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace BLLayer.TeamService
{
   public interface ITeam
    {
        List<Team> GetList();
        List<Team> ChooseTeamsForGame();
        Team RandomTeam();
        List<Team> ChooseTeams(List<Team> allTeams, List<Team> players);
        Team ChooseTeam(List<Team> players);
        Team GetTeamById(int Id);
        void AddToTeam(int IdPlayer, int IdTeam);
    }
}
