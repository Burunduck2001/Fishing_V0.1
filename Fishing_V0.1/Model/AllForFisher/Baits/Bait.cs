using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model.AllForFisher.Baits
{
    public class Bait : Tackle
    {
        public int Luck { get; set; }
        public List<Fish> WFEats { get; set; } //Which fish eats
        //TODO Something with list
        public Bait (int Id, string Name, int Cost, int minLvl, int Luck):base(Id, Name, Cost, minLvl)
        {
            this.Luck = Luck;
        }
    }
}
