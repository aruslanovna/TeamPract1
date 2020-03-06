using System;
using System.Collections.Generic;
using System.Text;
using TeamPract1.Events;
using Domain;

using BLLayer.TeamService;
using BLLayer;
using BLLayer.CoachService;
using BLLayer.PlayerService;
using BLLayer.RefereeService;

namespace TeamPract1
{
    public class Match
    {
        static void Main(string[] args)
        {
            SmthHappened score = new SmthHappened();
            score.ChangeScoreNotify += DisplayMessage;
            score.Whistle();

            ITeam teams = Factory.GetTeamModuleObject();
            teams.AddToTeam(1, 1);
            teams.AddToTeam(2, 1);
            teams.AddToTeam(3, 1);
            teams.AddToTeam(1, 1);
            teams.AddToTeam(5, 2);
            teams.AddToTeam(7, 1);
            teams.AddToTeam(2, 2);

            IPlayer players = Factory.GetPlayerModuleObject();
            players.Shoot(1,2);
            players.Shoot(1, 2);

            ICoach coach = Factory.GetCoachModuleObject();
            coach.plusForTeam(coach.GetCoachById(1));
            score.ShowScore(teams.GetTeamById(1), teams.GetTeamById(2));


            coach.plusForTeam(coach.GetCoachById(1));
            score.ShowScore(teams.GetTeamById(1), teams.GetTeamById(2));
            List<Player> p = teams.GetTeamById(1).players;

            


            IReferee referee = Factory.GetRefereeModuleObject();
            referee.addToFavouriteTeam(referee.GetRefereeById(1));
            referee.addToFavouriteTeam(referee.GetRefereeById(1));


            score.ShowScore(teams.GetTeamById(1), teams.GetTeamById(2));

           


            Game game = new Game();



           
            // playerAction.Shoot(player1, player11);
            score.Gol(1, game);

            //score.RefereePrefer(referee);
            //score.CouchTime(coach1);
            //score.CouchTime(coach1);
            //score.CouchTime(coach1);

            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            //score.Gol(ChooseTeamForGoal(teamsInGame), game);
            score.ShowScore(teams.GetTeamById(1), teams.GetTeamById(2));

            Console.ReadKey();

        }

        private static void DisplayMessage(object sender, GameEventArgs e)
        {
            Console.WriteLine(e.Message);
        }

    }
}


