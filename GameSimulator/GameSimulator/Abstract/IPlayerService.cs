using System;
using System.Collections.Generic;
using System.Text;
using GameSimulator.Adapters;
using GameSimulator.Entities;

namespace GameSimulator.Abstract
{
    public interface IPlayerService
    {
        void Add(Player player);
        void Update(Player player);
        void Delete(Player player);
    }
    
}
