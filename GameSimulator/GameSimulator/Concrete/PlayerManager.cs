using GameSimulator.Abstract;
using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class PlayerManager : IPlayerService
    {

        public void Add(Player player)
        {
            Console.WriteLine("Player " + player.FirstName + " " + player.LastName + " joined to the game.");
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player " + player.FirstName + " " + player.LastName + " is deleted from game db.");
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player " + player.FirstName + " " + player.LastName + " 's information is updated.");
        }
    }
}
