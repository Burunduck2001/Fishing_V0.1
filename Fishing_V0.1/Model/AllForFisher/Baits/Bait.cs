﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model.AllForFisher.Baits
{
    public class Bait
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Luck { get; set; }
        int Cost { get; set; }
        int minLvl { get; set; }
        public List<Fish> WFEats { get; set; } //Which fish eats
    }
}
