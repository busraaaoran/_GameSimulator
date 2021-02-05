using GameSimulator.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Entities
{
    public class Player:IEntity
    {
        public long TCKN { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime DateOfBirth { get; set; }

    }
}
