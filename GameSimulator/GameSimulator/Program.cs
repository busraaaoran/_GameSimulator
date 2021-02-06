using GameSimulator.Concrete;
using GameSimulator.Abstract;
using GameSimulator.Entities;
using System;
using GameSimulator.Adapters;

namespace GameSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            SalesManager salesManager = new SalesManager();
            PlayerManager playerManager = new PlayerManager(new MernisServiceAdapter());
            CampaignManager campaignManager = new CampaignManager();
            //MernisServiceAdapter mernisServiceAdapter = new MernisServiceAdapter();

            Player player1 = new Player
            {
                DateOfBirth = new DateTime(1999, 3, 20),
                FirstName = "Büşra",
                LastName = "Oran",
                TCKN = 12345678910
            };

            Player player2 = new Player
            {
                DateOfBirth = new DateTime(1984, 6, 8),
                FirstName = "Cengiz",
                LastName = "Koray",
                TCKN = 15555555550
            };

            Player player3 = new Player
            {
                DateOfBirth = new DateTime(1979, 2, 10),
                FirstName = "Erdal",
                LastName = "Beşikçi",
                TCKN = 66666666610
            };



            playerManager.Add(player1);
            playerManager.Add(player2);
            playerManager.Add(player3);

            Console.WriteLine("-----------");
            Game game1 = new Game
            {
                GameName = "League of Legends",
                Price = 35.50

            };

            Game game2 = new Game
            {
                GameName = "GTA",
                Price = 95.00

            };

            Game game3 = new Game
            {
                GameName = "CS:GO",
                Price = 65.90

            };

            Campaign campaign1 = new Campaign
            {
                DiscountRatio = 15,
                CampaignID = "1236"
            };

            Campaign campaign2 = new Campaign
            {
                DiscountRatio = 45,
                CampaignID = "4446"
            };

            salesManager.Add(player1, game1, campaign1);
            
            
        }
    }
}
