using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSampleAnimal
{
     // Ön tanımlı listelerimi enum ile tanımlayabiirim
     public enum HouseType
    {
        // bunların default değerleri int
        small,
        regular,
        big
    }

    public class Cat : Animal
    {
        public Cat() {
            Console.WriteLine("Cat Class Constructor initialized");
        }

        public string CatHouse { get; set; }

        public double CatHousePrice(HouseType houseType)
        {
            double price = 0.0;
            switch (houseType) { 
                case HouseType.small:
                    price = 300;
                    break;
                case HouseType.regular:
                    price = 500;
                    break;
                case HouseType.big:
                    price = 750;
                    break;
            }
            return price;
        }
    }
}
