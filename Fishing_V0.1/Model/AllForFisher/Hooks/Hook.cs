using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model.AllForFisher.Hooks
{
    public class Hook:Tackle
    {
        int Strength { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }

        public Hook(int Id, string Name, int Cost, int minLvl, int Power, int Strength, int Luck) : base(Id, Name, Cost, minLvl)
        {
            this.Strength = Strength;
            this.Power = Power;
            this.Luck = Luck;
        }
    }
}
