﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UltimateDepthCalculator
{
    public class Branch
    {
        public List<Branch> Branches { get; set; } = new();
    }
}
