using Domain;
using Domain.Lists;
using Repository.TeamRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class TeamModule: ITeamModule
    {
         static TeamModule()
        {

            LoadTeams();
        }
        static List<Team> _teams;
        public static List<Team> teamsInGame = new List<Team>();
        readonly static TeamList t = new TeamList();
           
        private static void LoadTeams()
        {
            _teams = new List<Team> {
            new Team() { Id =1,Name = "team1", result = 0, players =new List<Player>() },
            new Team() { Id = 2, Name = "team2", result = 0, players =new List<Player>() },
            new Team() { Id = 3, Name = "team3", result = 0, players =new List<Player>() }
        };
                t.allTeams = _teams;
           
        }
       
        public  List<Team> GetList()
        { 
            List<Team> allTeams = t.GetElementsList();
            return allTeams;
        }

        public List<Team> ChooseTeamsForGame()
        {
           
            DefineTeam d = new DefineTeam();
            d.ChooseTeamsForGame(GetList(), teamsInGame);
            return teamsInGame;

        }
       
        public Team FirstTeamInGame()
        { 
            return  teamsInGame?[0];
        }

        public Team SecondTeamInGame()
        {
            return teamsInGame?[1];
        }

        public  Team ChooseRandomTeam()
        {
            ChooseTeamsForGame();
            Random rnd = new Random();
            int r = rnd.Next(teamsInGame.Count);
            return teamsInGame[r];

        }
        public Team GetTeamById(int Id)
        {
            List<Team> teams = GetList();
            Team team = teams.Select(t=>t).Where(t=>t.Id==Id).FirstOrDefault() ;
            return team;

        }

       
        public List<Player> GetPlayers()
        {
            PlayerModule pl = new PlayerModule();
            return pl.GetPlayers();
           

        }
        public void AddToTeam(int IdPlayer, int IdTeam)
        {
            var t = GetList().Select(t => t).Where(t => t.Id == IdTeam && ChooseTeamsForGame().Contains(t)).FirstOrDefault();
            var p = GetPlayers().Select(x => x).Where(x => x.Id == IdPlayer).FirstOrDefault();
            try
            {
                t.players.Add(p);
            }
            catch
            {
               Console.WriteLine( StringLiterals.NoSuchTeam);
            }
        }
    }
}
