using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstanceSample
{
    public class Iron
    {
        //Empty construcor
        public Iron()
        {
            Console.WriteLine("Iron Constructor");
        }

        //Constructors with parameters
        public Iron(string brand, string color, int temperature, bool hasSteamGenerator) 
        {
            //set çalışıyor
            this.Brand = brand; // this şart değil
            this.Color = color; 
            this.Temperature = temperature;
            this.HasSteamGenerator = hasSteamGenerator;

            //get çalışıyor
            string ironInformation =
                $"Iron object has been created with following information: \n" +
                $"Brand: {this.Brand}\n" +
                $"Color: {this.Color}\n" +
                $"Temperature: {this.Temperature}\n" +
                $"HasSteamGenerator: {(this.HasSteamGenerator ? "Yes" : "No")}";
            Console.WriteLine(ironInformation);
        }

        public Iron(string brand){
            Brand = brand; // this şart değil
            string ironInformation =
                $"This iron's brand is {this.Brand}";
            Console.WriteLine(ironInformation);
        }

        public void HeatUp(int degree)
        {
            this.Temperature += degree;
            Console.WriteLine($"The iron's temperature has increased. Current temperature {this.Temperature}");
        }

        //Properties
        public string Brand { get; set; }
        public string Color { get; set; }
        public int Temperature { get; set; }
        public bool HasSteamGenerator { get; set; }
    }
}
