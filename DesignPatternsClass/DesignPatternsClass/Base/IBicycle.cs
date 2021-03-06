﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatternsClass
{
    public interface IBicycle
    {
        IWheel Wheel { get; }
        BikeColor ColorType { get; }

        void Paint(BikeColor color);
    }
}
