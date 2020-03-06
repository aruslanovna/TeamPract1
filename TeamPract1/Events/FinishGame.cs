using System;
using System.Collections.Generic;
using System.Text;

namespace TeamPract1.Events
{
    public class FinishGame : EventArgs
    {

        public int team1Result;
        public int team2Result;
        public FinishGame(int team1Result, int team2Result)
        {
            this.team1Result = team1Result;
            this.team2Result = team2Result;
        }


    }
}
