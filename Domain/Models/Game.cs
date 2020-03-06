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
      

    }
}
