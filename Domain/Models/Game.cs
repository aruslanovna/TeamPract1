using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Game
    {

        public List<Team> teams;
        public Referee referee;
        public DateTime date { get; set; }
        public int MaxScore { get; set; }
        public bool isActive { get; set; }
        //public Game(List<Team> teams, Referee referee, DateTime date, int maxScore)
        //{
        //    this.teams = teams;
        //    this.referee = referee;
        //    this.date = date;
        //    this.MaxScore = maxScore;
        //    isActive = false;
        //}

    }
}
