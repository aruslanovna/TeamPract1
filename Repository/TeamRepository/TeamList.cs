using Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repository.TeamRepository
{
    public class TeamList
    {
        public List<Team> allTeams = new List<Team>();

        public void Add(Team team)
        {
            if (!Contains(team))
            {
                allTeams.Add(team);
                Console.WriteLine($"Team {team.Name} added to list");
            }
            else
            {
                Console.WriteLine($"Team {team.Name} already exists in list of teams");
            }
        }

        public bool Contains(Team team)
        {
            if (allTeams.Contains(team))
            {
                return true;
            }
            return false;
        }

        public void Remove(Team team)
        {
            if (allTeams.Contains(team))
            {
                allTeams.Remove(team);
                Console.WriteLine($"Team {team.Name} removed from list succesfully");
            }
            else
            {
                Console.WriteLine($"Team {team.Name} doesn't exist in team list");
            }
        }

        public void ResetGame()
        {
            allTeams.Clear();
        }

        public IEnumerable<Team> GetElements()
        {

            foreach (Team t in allTeams)
            {
                Console.Write(t.Name + " ");
            }
            return allTeams;
        }

        public List<Team> GetElementsList()
        {
            return allTeams;
        }
    }
}
