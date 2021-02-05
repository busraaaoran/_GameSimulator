using GameSimulator.Abstract;
using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class SalesManager : ISalesService
    {
        public void Add(Player player, Game game)
        {
            Console.WriteLine("Player "+player.FirstName+" "+player.LastName+" purchased "+game.GameName+" for "+game.Price+" pound.");
        }

        public void Delete()
        {
            throw new NotImplementedException();
        }

        public void Update()
        {
            throw new NotImplementedException();
        }
    }
}
