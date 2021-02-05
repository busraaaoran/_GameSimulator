using GameSimulator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Entities
{
    public class Campaign:IEntity
    {
        public float DiscountRatio { get; set; }

        public int CampaignID { get; set; }

    }
}
