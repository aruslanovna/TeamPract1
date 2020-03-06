using System;
using System.Collections.Generic;
using System.Text;

namespace Domain
{
    public class Referee:Person
    {
       
        public Team FavouriteTeam { get; set; }
      
        //public Referee(int Id,string Name,  Team FavouriteTeam,int experience)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.Experience = experience;
        //    this.FavouriteTeam = FavouriteTeam;
        //}
    }
}
