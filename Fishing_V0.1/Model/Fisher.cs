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
        public Location Location { get; set; }
        public int Power { get; set; }
        public int Luck { get; set; }
        public int Lvl { get; set; }
        public int Expierience { get; set; }
        public int CoinsSilver { get; set; }
        public int CoinsGold { get; set; }


        public int SetPower()
        {
            return Hook.Power+FishingRod.Power; 
        }

        public int SetLuck()
        {
            return Hook.Luck+Bait.Luck;
        }

        public void ChangeStates()
        {
            Power = SetPower();
            Luck = SetLuck();
        }

        public Fisher()
        {
            FishingRod = null;
            Hook = null;
            Bait = null;
            Lvl = 1;
            CoinsSilver = 100;
            CoinsGold = 10;
        }
    }
}
