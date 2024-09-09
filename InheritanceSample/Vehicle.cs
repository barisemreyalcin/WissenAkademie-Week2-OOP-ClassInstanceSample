using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSample
{
    // Türetilecek class'ların ortak özelliklerinin, metotlarının ve fonksiyonlarının topladığım sınıf BASE CLASS
    public class Vehicle
    {
        public Vehicle() // Constructor
        {
            Console.WriteLine("Vehicle constructor initialized");
            MaxSpeed = 200;
        }

        public Vehicle(int maxSpeed = 200) // Constructor
        {
            this.MaxSpeed = maxSpeed;
        }

        // Instance'ları ayırt etmek için ve property vs'lere ulaşmak için bir unique anahtar her zaman olmalı
        public int Id { get; set; }
        public int Capacity { get; set; }
        public int MaxSpeed { get; set; }
        protected int WheelsCount { get; set; } // Sadece bu classtan türetilen classlarda olsun istiyorum. Instancelerde erişilemez. Derived Class'ta erişilir ama onun instance'sinde de erişilemez

    }
}
