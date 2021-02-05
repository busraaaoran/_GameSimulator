using GameSimulator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Entities
{
    public class Campaign:IEntity
    {
        public int DiscountRatio { get; set; }

        public string CampaignID { get; set; }

    }
}
