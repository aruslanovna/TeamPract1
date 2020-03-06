using Domain;
using Repository.TeamRepository;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Repository
{
    public class CoachModule : ICoachModule
    {
        public CoachModule()
        {
            LoadCoach();
        }
        TeamModule teamModule = new TeamModule();
        List<Coach> coachList = new List<Coach>();
        private void LoadCoach()
        {
            coachList = new List<Coach> {
            new Coach() { Id = 1, Name = "Chan", Experience = 39, Team = teamModule.GetTeamById(1) },



            new Coach() { Id = 2, Name = "Fiona", Experience = 50, Team = teamModule.GetTeamById(2) }

        };
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

        public Coach GetCoachById(int coachId)
        {
            Coach c = coachList.Select(x => x).Where(x=>x.Id==coachId).FirstOrDefault();
            return c;
        }
    }
}