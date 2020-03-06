using System;
using System.Collections.Generic;
using System.Text;

namespace Domain.Lists
{
   public class PlayerList
    {
       
            public  List<Player> allPlayers = new List<Player>();

            public void Add(Player player)
            {
                if (!Contains(player))
                {
                allPlayers.Add(player);
                    Console.WriteLine($"player {player.Name} added to list");
                }
                else
                {
                    Console.WriteLine($"player {player.Name} already exists in list of teams");
                }
            }

            public bool Contains(Player player)
            {
                if (allPlayers.Contains(player))
                {
                    return true;
                }
                return false;
            }

            public void Remove(Player player)
            {
                if (allPlayers.Contains(player))
                {
                allPlayers.Remove(player);
                    Console.WriteLine($"player {player.Name} removed from list succesfully");
                }
                else
                {
                    Console.WriteLine($"player {player.Name} doesn't exist in team list");
                }
            }

            public void ResetGame()
            {
            allPlayers.Clear();
            }

            public IEnumerable<Player> GetElements()
            {

                foreach (Player t in allPlayers)
                {
                    Console.Write(t.Name + " ");
                }
                return allPlayers;
            }

            public List<Player> GetElementsList()
            {
                return allPlayers;
            }
        }
    
}
