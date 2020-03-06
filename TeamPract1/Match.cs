using System;
using System.Collections.Generic;
using System.Text;
using TeamPract1.Events;


using Domain;
using Repository;

namespace TeamPract1
{
    public class Match
    {
        static void Main(string[] args)
        {

            
           
            IPlayerModule players = Factory.GetPlayerModuleObject();
            ITeamModule teams = Factory.GetTeamModuleObject();
            teams.AddToTeam(1,1);
            teams.AddToTeam(2, 1);
            teams.AddToTeam(3, 1);
            teams.AddToTeam(1, 1);
            teams.AddToTeam(5, 2);
            teams.AddToTeam(7, 1);
            teams.AddToTeam(2, 2);
            players.Shoot(1,2);
            players.Shoot(1, 2);
            Console.WriteLine(teams.GetTeamById(1).result);
            List<Player> p = teams.GetTeamById(1).players;

          foreach(var t in p)
            {
                Console.WriteLine($"{t.Name} added to team");
            }
            
            ICoachModule coach = Factory.GetCoachModuleObject();
           
            IRefereeModule referee = Factory.GetRefereeModuleObject();
           

            //team1.players.Add(player1);
            //team1.players.Add(player2);
            //team1.players.Add(player3);
            //team1.players.Add(player4);
            //team1.players.Add(player5);
            //team1.players.Add(player6);
            //team2.players.Add(player7);
            //team2.players.Add(player8);
            //team2.players.Add(player9);
            //team2.players.Add(player10);
            //team2.players.Add(player11);
            //team2.players.Add(player12);

            //TeamsList allTeams = new TeamsList();
            //allTeams.Add(team1);
            //allTeams.Add(team2);
            //allTeams.Add(team3);



            //  List<Team> teamsInGame = new List<Team>();
            //  ChooseTeam(allTeams.GetElementsList(), teamsInGame);
            // Referee referee = new Referee(1,"MainPerson", ChooseTeamForGoal(teamsInGame), 34);



            //Game game = new Game(teamsInGame, referee, DateTime.Now, SmthHappened.maxScore);



            //SmthHappened score = new SmthHappened();
            //SomebodyAction playerAction = new SomebodyAction();
            //playerAction.team = teamsInGame;
            //score.ChangeScoreNotify += DisplayMessage;
            //score.Whistle(game);
            //playerAction.Shoot(player1,player11);
            //score.Gol(ChooseTeamForGoal(teamsInGame),game);
            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.RefereePrefer(referee);
            //score.CouchTime(coach1);
            //score.CouchTime(coach1);
            //score.CouchTime(coach1);

            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.ShowScore(teamsInGame[0], teamsInGame[1]);

            Console.ReadKey();

        }

        private static void DisplayMessage(object sender, GameEventArgs e)
        {
            Console.WriteLine(e.Message);

        }




    }
}


