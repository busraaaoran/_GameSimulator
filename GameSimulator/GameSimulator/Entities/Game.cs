using GameSimulator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Entities
{
    public class Game:IEntity
    {
        public double Price { get; set; }

        public string GameName { get; set; }

    }
}
