using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Coach : Person
    {
        
        public  Team Team { get; set; }
       
        //public Coach(int Id,string Name, int Experience, Team Team)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Experience = Experience;
        //    this.Team = Team;
        //}

    }
}
