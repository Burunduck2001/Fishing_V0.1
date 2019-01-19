using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model.AllForFisher.FishingRods
{
    public class FishingRod : Tackle
    {
        int Strength { get; set; }
        public int Power { get; set; }
        public FishingRod(int Id, string Name, int Cost, int minLvl, int Power, int Strength) : base(Id, Name, Cost, minLvl)
        {
            this.Strength = Strength;
            this.Power = Power;
        }
    }
}
