using Domain;
using Repository.TeamRepository;
using System;

namespace Repository
{
    public class CoachModule : ICoachModule
    {
        public CoachModule()
        {
            LoadCoach();
        }
        TeamModule teamModule = new TeamModule(); 
        private void LoadCoach()
        {
            Coach c1 = new Coach() { Id = 1, Name = "Chan", Experience = 39 };
            c1.Team = teamModule.GetTeamById(c1.Id);

            Coach c2 = new Coach() { Id = 2, Name = "Fiona", Experience = 50 };
            c2.Team = teamModule.GetTeamById(c2.Id);
        }

        public void plusForTeam(Coach coach)
        {
            Team team = coach.Team;
            if (coach.Experience >= 20)
            {
                team.result += 3;
            }
            else if (coach.Experience >= 40)
            {
                team.result += 4;
            }

        }
    }
}