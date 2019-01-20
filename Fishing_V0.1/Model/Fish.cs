
using Fishing_V0._1.Model.AllForFisher.Baits;
using System.Collections.Generic;

namespace Fishing_V0._1.Model
{
    public class Fish
    {
        public int Id { get; set; }
        public Rarity rarity { get; set; }
        public string TypeName { get; set; }
        public int Exp { get; set; }
        public List<Bait> WhatFishEat { get; set; }// All baits that Fish can it
        public double Power { get; set; }
        public double Weight { get; set; }
        public double Size { get; set; }
        public int Price { get; set; }//In silver coins for 1kg
        public int Chance { get; set; }

        public enum Rarity
        {
            Common,
            Uncommon,
            Rare,
            Uniqle,
            Legendary
        }
        // public Bitmap ImageType { get; set; }

        public Fish()
        {

        }

        protected double GetSize(double minSize, double maxSize)
        {
            System.Random random = new System.Random();
            minSize *= 1000;
            maxSize *= 1000;
            return random.Next((int)minSize, (int)maxSize) / 1000;

        }

        protected double GetWeight(double minWeight, double maxWeight)
        {
            System.Random random = new System.Random();
            minWeight *= 1000;
            maxWeight *= 1000;
            return random.Next((int)minWeight, (int)maxWeight) / 1000;

        }

    }
}
        
    

