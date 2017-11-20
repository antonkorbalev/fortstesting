﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ForexRobotLib.Calculator;

namespace ForexRobotLib.Genetics
{
    public class PopulationCompletedEventArgs : EventArgs
    {
        public int PopulationIndex { get; set; }
        public CalculationResult[] Results { get; set; }
    }
}
