using Fishing_V0._1.Model.AllForFisher;
using Fishing_V0._1.Model.AllForFisher.Baits;
using Fishing_V0._1.Model.AllForFisher.FishingRods;
using Fishing_V0._1.Model.AllForFisher.Hooks;

namespace Fishing_V0._1.Model
{
    class Fisher
    {

        public Backpack Backpack { get; set; }
        public FishingRod FishingRod { get; set; }
        public Hook Hook { get; set; }
        public Bait Bait { get; set; }

        public int Power { get; set; }
        public int Luck { get; set; }
        public int Lvl { get; set; }
        public int Expierience { get; set; }
        public int CoinsSilver { get; set; }
        public int CoinsGold { get; set; }


        public int SetPower()
        {
            return Power; 
        }

        public int SetLuck()
        {
            return Luck;
        }

        public void ChangeStates()
        {

        }

        public Fisher()
        {
            FishingRod = null;
            Hook = null;
            Bait = null;
        }
    }
}
