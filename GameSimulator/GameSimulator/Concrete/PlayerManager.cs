using GameSimulator.Abstract;
using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class PlayerManager : IPlayerService,IPlayerCheckService
    {
        IPlayerCheckService _playerCheckService;


        public PlayerManager(IPlayerCheckService playerCheckService)
        {
            _playerCheckService = playerCheckService;
        }

        public void Add(Player player)
        {
            if (_playerCheckService.IsPerson(player))
            {
                Console.WriteLine("Player " + player.FirstName + " " + player.LastName + " joined to the game.");
            }
            else
            {
                Console.WriteLine("Player " + player.FirstName + " " + player.LastName + " could not verified by system.");
            }
            
        }

        public void Delete(Player player)
        {
            Console.WriteLine("Player " + player.FirstName + " " + player.LastName + " is deleted from game db.");
        }

        public bool IsPerson(Player player)
        {
            throw new NotImplementedException();
        }

        public void Update(Player player)
        {
            Console.WriteLine("Player " + player.FirstName + " " + player.LastName + " 's information is updated.");
        }
    }
}
