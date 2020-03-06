using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using Domain.Enums;

namespace Repository
{
    public class PlayerProcessorFactory : IPlayerProcessorFactory
    {
        List<Player> players = new List<Player>();
        public void DeleteFromField(int Id)
        {
            Player player = players.Select(t => t).Where(t => t.Id == Id).FirstOrDefault();
            player.Status = (int)Status.DeletedFromField;

        }

        public void GiveRedCard(int Id)
        {
            Player player = players.Select(t => t).Where(t => t.Id == Id).FirstOrDefault();
            player.Status = (int)Status.WithRedCard;
        }

        public void GiveYellowCard(int Id)
        {
            Player player = players.Select(t => t).Where(t => t.Id == Id).FirstOrDefault();
            player.Status = (int)Status.WithYellowCard;
        }

        public void ProduceOnField(int Id)
        {
            Player player = players.Select(t => t).Where(t => t.Id == Id).FirstOrDefault();
            player.Status = (int)Status.onField;
        }
    }
}
