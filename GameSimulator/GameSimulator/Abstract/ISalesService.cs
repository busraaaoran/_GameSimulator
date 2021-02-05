﻿using GameSimulator.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSimulator.Abstract
{
    public interface ISalesService
    {
        void Add(Player player, Game game);
        void Update();
        void Delete();
    }
}
