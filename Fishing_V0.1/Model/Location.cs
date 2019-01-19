using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing_V0._1.Model
{
    class Location
    {
        int Id { get; set; }
        string Name { get; set; }
        int minLvlEnter { get; set; }
        public List<Fish> AvailableFishes { get; set; }
        //Background
        //Sound

        public Location(int id, string name, int minlvl)
        {
            Id = id;
            Name = name;
            minLvlEnter = minlvl;
            AvailableFishes = new List<Fish>();
        }

        public void AddFish(Fish fish)
        {
            AvailableFishes.Add(fish);
        }
    }
}
