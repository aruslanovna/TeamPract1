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
            ITeamModule teams = Factory.GetTeamModuleObject();
            teams.AddToTeam(1, 1);
            teams.AddToTeam(2, 1);
            teams.AddToTeam(3, 1);
            teams.AddToTeam(1, 1);
            teams.AddToTeam(5, 2);
            teams.AddToTeam(7, 1);
            teams.AddToTeam(2, 2);

            IPlayerModule players = Factory.GetPlayerModuleObject();
            players.Shoot(1,2);
            players.Shoot(1, 2);

            ICoachModule coach = Factory.GetCoachModuleObject();
            coach.plusForTeam(coach.GetCoachById(1));

            
            List<Player> p = teams.GetTeamById(1).players;


            IRefereeModule referee = Factory.GetRefereeModuleObject();
            referee.addToFavouriteTeam(referee.GetRefereeById(1));

            Console.WriteLine(teams.GetTeamById(1).result);


            foreach (var t in p)
            {
                Console.WriteLine($"{t.Name} added to team");
            }
            
         
           


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


