using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.TeamRepository
{
   public class DefineTeam
    {
        public List<Team> ChooseTeamsForGame(List<Team> allTeams, List<Team> players)
        {
            while (players.Count < 2)
            {
                Random rnd = new Random();
                int r = rnd.Next(allTeams.Count);
                if (!players.Contains(allTeams[r]))
                {
                    players.Add(allTeams[r]);
                    Console.WriteLine($"{(string)allTeams[r].Name}  is playing today");
                }
            }
            return players;

        }


        public  Team ChooseTeam(List<Team> players)
        {

            Random rnd = new Random();
            int r = rnd.Next(players.Count);
            return players[r];

        }
    }
}
