
using Fishing_V0._1.Model.AllForFisher.Baits;
using System.Collections.Generic;

namespace Fishing_V0._1.Model
{
    public class Fish
    {
        public int Id { get; set; }
        public int Weight { get; set; } //In killograms
        public int Size { get; set; } //In metrs
        public int Price { get; set; }//In silver coins
        public Rarity rarity { get; set; }
        public string Type { get; set; }
        public int Exp { get; set; }
        public List<Bait> WhatFishEat {get;set;}// All baits that Fish can it

        public enum Rarity
        {
            Common,
            Uncommon,
            Rare,
            Uniqle,
            Legendary
        }
        // public Bitmap ImageType { get; set; }


        
    }
}
