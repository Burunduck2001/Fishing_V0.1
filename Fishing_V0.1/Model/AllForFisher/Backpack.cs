using Fishing_V0._1.Model.AllForFisher.Baits;
using Fishing_V0._1.Model.AllForFisher.FishingRods;
using Fishing_V0._1.Model.AllForFisher.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model.AllForFisher
{
    class Backpack
    {
        Dictionary<string, FishingRod> Roads { get; set; }
        Dictionary<string, Hook> Hooks { get; set; }
        Dictionary<string, Bait> Baits { get; set; }
    }
}
