using GameSimulator.Abstract;
using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Concrete
{
    class CampaignManager : ICampaignService
    {
        public void Add(Campaign campaign)
        {
            Console.WriteLine("The %" + campaign.DiscountRatio + "discount campaign with " + campaign.CampaignID + " ID is added to the system");
        }

        public void Delete(Campaign campaign)
        {
            Console.WriteLine("The %" + campaign.DiscountRatio + "discount campaign with " + campaign.CampaignID + " ID is deleted from the system");
        }

        public void Update(Campaign campaign)
        {
            Console.WriteLine("The %" + campaign.DiscountRatio + "discount campaign with " + campaign.CampaignID + " ID is updated.");
        }
    }
}
