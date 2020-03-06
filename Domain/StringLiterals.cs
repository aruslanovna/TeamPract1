using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public static class StringLiterals
    {
        public static string Whistle { get { return Environment.NewLine + "ARE YOU READY? " + Environment.NewLine + "The game started! "; } }
        public static string Final {get { return Environment.NewLine + "The last whistle! Thank you all for the game"; } }

        public static object NoSuchTeam { get { return "Team with this Id doesn't play in this match"; } }
        public static object NoSuchPlayerInTeam { get { return "Team doesn't contain this player"; } }
    }
}
