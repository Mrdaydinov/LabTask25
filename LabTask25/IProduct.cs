﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask25
{
    internal interface IProduct
    {
        decimal GetPrice();
        void ReduceStock(int reduceAmount);
    }
}
