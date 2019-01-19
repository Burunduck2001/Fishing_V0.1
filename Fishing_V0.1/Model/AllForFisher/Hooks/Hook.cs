using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model.AllForFisher.Hooks
{
    abstract class Hook
    {
        int Strength { get; set; }
        int Power { get; set; }
        int Cost { get; set; }
        int Luck { get; set; }
    }
}
