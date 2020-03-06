using Domain;
using Domain.Enums;
using Domain.Lists;
using Repository.TeamRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repository
{
    public class PlayerModule : IPlayerModule
    {
        public PlayerModule(){
            LoadPlayers();
        }

       TeamModule teamMod = new TeamModule();
        private static List<Player> _players;
       
        public List<Player> GetPlayers()
        {
            PlayerList p = new PlayerList();
            p.allPlayers = _players;
            List<Player> allPlayers = p.GetElementsList();
            return allPlayers;

        }



        public void Shoot(int goalkeeperId, int attackerId)
        {
            var attacker = GetPlayers().Select(x => x).Where(x => x.Id == attackerId).FirstOrDefault();
            var goalKeeper = GetPlayers().Select(x => x).Where(x => x.Id == goalkeeperId).FirstOrDefault();

            if (goalKeeper.Lucky <= attacker.Lucky || goalKeeper.Experience <= attacker.Experience)
            {


                var luckyTeam = teamMod.GetList().Select(p => p).Where(p => p.players.Any(x => x.Id == attackerId)).First();
                luckyTeam.result += 1;
            }
        }

      
        private static void LoadPlayers()
        {
            _players = new List<Player>
            {
                new Player(){ Id= 1,Name="Ivan1", Experience= 2 ,Lucky=1.5, Status= (int)Status.onField },
                 new Player(){ Id= 2,Name="Ivan2", Experience= 3 ,Lucky=1.5, Status= (int)Status.onField },
                 new Player(){ Id= 3,Name="Ivan3", Experience= 11 ,Lucky=2, Status= (int)Status.onField },
                  new Player(){ Id= 4,Name="Ivan4", Experience= 21 ,Lucky=1, Status= (int)Status.onField },
                  new Player(){ Id= 5,Name="Ivan5", Experience= 5 ,Lucky=0.5, Status= (int)Status.onField },
                 new Player(){ Id= 6,Name="Ivan6", Experience= 7 ,Lucky=1.5, Status= (int)Status.onField },
                 new Player(){ Id= 1,Name="Fedor1", Experience= 2 ,Lucky=0.5, Status= (int)Status.onField },
                 new Player(){ Id= 2,Name="Fedor2", Experience= 2 ,Lucky=0.5, Status= (int)Status.onField },
                  new Player(){ Id= 3,Name="Fedor3", Experience= 5 ,Lucky=2, Status= (int)Status.onField },
                   new Player(){ Id= 4,Name="Fedor4", Experience= 12 ,Lucky=1, Status= (int)Status.onField },
                    new Player(){ Id= 5,Name="Fedor5", Experience= 2 ,Lucky=0.5, Status= (int)Status.onField },
                     new Player(){ Id= 6,Name="Fedor6", Experience= 7 ,Lucky=3.5, Status= (int)Status.onField },
                      new Player(){ Id= 7,Name="Fedor7", Experience= 11 ,Lucky=1.5, Status= (int)Status.onField }

            };

        }
    }
}
