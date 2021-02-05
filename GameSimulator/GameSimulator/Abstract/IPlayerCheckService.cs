using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Abstract
{
    public interface IPlayerCheckService
    {
        bool IsPerson(Player player);
    }
}
