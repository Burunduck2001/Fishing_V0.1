using Fishing_V0._1.Model.AllForFisher.Baits;
using Fishing_V0._1.Model.AllForFisher.FishingRods;
using Fishing_V0._1.Model.AllForFisher.Hooks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model
{
    class GameEngine
    {
        List<Location> Map = new List<Location>();
        List<FishingRod> FishingRods = new List<FishingRod>();
        List<Hook> Hooks = new List<Hook>();
        List<Bait> Baits = new List<Bait>();
        Fisher Fisher = new Fisher();
     
        Fish Pescar = new Fish(0, 0.1, 0.2, 0.01, 0.1, 1, Fish.Rarity.Common, "Пескарь");

        
        public void InitializeComponent()
        {
            CreateFishingRods();
            CreateHooks();
            CreateBaits();

        }

        public void CreateFishingRods()
        {
            FishingRods.Add( new FishingRod(0,"Деда", 20, 1, 10, 5));
        }

        public void CreateHooks()
        {
            Hooks.Add(new Hook(0, "Лоховской", 10, 1, 1, 1, 1));
        }

        public void CreateBaits()
        {
            Baits.Add(new Bait(0, "Хлеб", 1, 1, 2));
        }

        public void CreateMap()
        {
            Map.Add(new Location(0, "Плотина", 1));
        }

    }
}
