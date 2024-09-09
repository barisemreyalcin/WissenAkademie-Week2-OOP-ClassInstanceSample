using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    // Derived Class (Türemiş)
    public class Car : Vehicle // Hangi sınıftan türetildiği yani miras aldığı yeri burası belirler
    {
        // public Car() : Base(150) deseydim Vehicle'de hangi constructor'u çalıştırmasını istediğimi söylerim
        public Car() // constructor
        {
            Console.WriteLine("Car constructor initialized");
            Id = 1;
            Capacity = 150;
            MaxSpeed = 350;
            WheelsCount = 4;
            DoorCount = 2;
        }

        public Car(int id, int doorCount) // constructor
        {
            Console.WriteLine("Car constructor with parameters initialized");
            Id = id;
            DoorCount = doorCount;
        }

        public int DoorCount { get; set; }
    }
}
// ctrl alt I yap