using Domain;
using Repository.TeamRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class RefereeModule:IRefereeModule
    {
        public RefereeModule()
        {
            LoadReferee();
        }
        private List<Referee> refereeList;
        Referee referee1;
        TeamModule teamMod = new TeamModule();
        public void LoadReferee()
        {
            refereeList = new List<Referee> {
                new Referee() { Id = 1, Experience = 30, FavouriteTeam = teamMod.RandomTeam(), Name = "Ivan Petrovich" }

                 };
        }

        
        public void addToFavouriteTeam(Referee referee)
        {
            Team favTeam = referee.FavouriteTeam;
            favTeam.result += 3;
        }

        public Referee GetRefereeById(int refereeId)
        {
            Referee r = refereeList.Select(x => x).Where(x => x.Id == refereeId).FirstOrDefault();
            return r;
        }
    }
}