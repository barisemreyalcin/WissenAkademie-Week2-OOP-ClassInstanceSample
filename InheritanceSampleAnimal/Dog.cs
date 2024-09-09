using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSampleAnimal
{
    public class Dog : Animal
    {
        public Dog()
        {
            Console.WriteLine("Dog Class Constructor initialized");
        }

        public int FoodPacketCount { get; set; }
        public double FoodPacketPrice { get; set; }
        public double CalcTotalPrice(int dailyFeedCount)
        {
            double totalPrice = dailyFeedCount * (FoodPacketPrice * FoodPacketCount);
            return totalPrice;
        }
    }
}
