using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model.AllForFisher.FishingRods
{
    public class FishingRod
    {
        public int Id { get; set; }
        public string Name { get; set; }
        int Strength { get; set; }
        int Power { get; set; }
        int Cost { get; set; }
        int minLvl { get; set; }
    }
}
