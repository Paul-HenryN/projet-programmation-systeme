﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitchenApp.contract
{
    internal interface IObserver
    {
        public void UpdateHasMoved(int pastX, int pastY, int newX, int newY);
    }
}