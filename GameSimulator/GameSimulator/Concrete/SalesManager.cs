using GameSimulator.Abstract;
using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class SalesManager : ISalesService
    {
        public void Add(Player player, Game game,Campaign campaign)
        {
            
            Console.WriteLine("Player "+player.FirstName+" "+player.LastName+" purchased "+game.GameName+" for "+(game.Price-(game.Price*campaign.DiscountRatio/100))+" pound with %"+campaign.DiscountRatio+" discount.");
        }

        public void Delete(Game game)
        {
            Console.WriteLine("The game " + game.GameName + " is deleted");
        }

        public void Update(Game game, Campaign campaign)
        {
            Console.WriteLine("The game " + " 's price is updated with %" + campaign.DiscountRatio + " dicount.");
        }
    }
}
