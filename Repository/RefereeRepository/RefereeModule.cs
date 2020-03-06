using Domain;
using Repository.TeamRepository;
using System;
using System.Collections.Generic;

namespace Repository
{
    public class RefereeModule:IRefereeModule
    {
        public RefereeModule()
        {
            LoadReferee();
        }
        private List<Referee> _referee;
        Referee referee1;
        TeamModule teamMod = new TeamModule();
        public void LoadReferee()
        {

            referee1 = new Referee() { Id = 1, Experience = 30, FavouriteTeam = teamMod.RandomTeam(), Name = "Ivan Petrovich" };
      
        }

        
        public void addToFavouriteTeam(Referee referee)
        {
            Team favTeam = referee.FavouriteTeam;
            favTeam.result += 3;
        }
    }
}