using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model.AllForFisher
{
    public class Tackle
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Cost { get; set; }
        public int minLvl { get; set; }

        public Tackle(int Id, string Name, int Cost, int minLvl)
        {
            this.Id = Id;
            this.Name = Name;
            this.Cost = Cost;
            this.minLvl = minLvl;
        }
    }
}
