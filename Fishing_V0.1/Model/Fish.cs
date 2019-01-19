
using Fishing_V0._1.Model.AllForFisher.Baits;
using System.Collections.Generic;

namespace Fishing_V0._1.Model
{
    public class Fish
    {
        public int Id { get; set; }
        public double minWeight { get; set; } //In killograms
        public double minSize { get; set; } //In metrs
        public double maxWeight { get; set; } //In killograms
        public double maxSize { get; set; } //In metrs
        public int Price { get; set; }//In silver coins
        public Rarity rarity { get; set; }
        public string TypeName { get; set; }
        public int Exp { get; set; }
        public List<Bait> WhatFishEat { get; set; }// All baits that Fish can it

        public enum Rarity
        {
            Common,
            Uncommon,
            Rare,
            Uniqle,
            Legendary
        }
        // public Bitmap ImageType { get; set; }

        public Fish(int id, double minWeight, double maxWeight, double minSize, double maxSize, int price, Rarity rarity,
            string typeName)
        {
            Id = id;
            this.minWeight = minWeight;
            this.maxWeight = maxSize;
            this.minSize = minSize;
            this.maxSize = maxSize;
            Price = price;
            this.rarity = rarity;
            TypeName = typeName;
        }


        
    }
}
