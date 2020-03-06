using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Team
    {
        public string Name { get; set; }
        public List<Player> players { get; set; }
        public int result { get; set; }
        public int Id { get; set; }
   
    }
}
