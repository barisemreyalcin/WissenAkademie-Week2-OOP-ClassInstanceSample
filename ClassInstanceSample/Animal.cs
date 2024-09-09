using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstanceSample
{
    public class Animal
    {
        //Construcor (Birden fazla olabilir - Overload mantığı)
        /// <summary>
        /// Animal class constructor
        /// </summary>
        public Animal()
        {
            //new ile çağrıldığında bu kodlar direkt run edilir
            Console.WriteLine("Animal Class Instance produced");
        }

        //Construcor
        /// <summary>
        /// Constructor that takes animal type
        /// </summary>
        /// <param name="animalType">animalType takes string value</param>
        public Animal(string animalType)
        {
            Console.WriteLine(animalType);
        }

        // Field zaten default private'tir. Ancak public yaparsam erişilebilir kılarım
        //private string animalType; // 1. yol: Right click'ten ilerle property oluştur
        // Yeni
        //public string AnimalType { get => animalType; set => animalType = value; }
        // Field varken yukardaki gibi yokken aşağıdaki gibi. Field olması şart değil

        // Yeni
        // 2. yol: prop + tab + tab ile aşağıdaki gibi de yazabilirsin
        public string AnimalType { get; set; }

        // Eskiden:
        //public string getAnimalType()
        //{
        //    return animalType;
        //}

        //public void setAnimalType(string _animalType)
        //{
        //    animalType = _animalType;
        //}

        // Eskiden: (Bir kontrol vs yapmak istersem kullanılabilir)
        //private string animalType; // field
        //public string AnimalType
        //{
        //    get { 
        //        if (!string.IsNullOrEmpty(animalType))
        //            return animalType;
        //         else
        //        {
        //            return "Empty value";
        //        }
        //    }
        //    set { animalType = value; }
        //}

        // another property
        public int Speed { get; set; }

        //Destructor (Yıkıcı) Method (1 tane olur)
        // bir şeyleri sonlandırma, null'a atama gibi şeyler düşün
        // biz çağıramayız, garbage collector çağırır
        ~Animal() { // class ismiyle aynı olmalı
            Console.WriteLine("Animal class has been removed from the memory");
        }
    }
}
