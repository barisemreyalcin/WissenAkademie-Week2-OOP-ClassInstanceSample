using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSampleAnimal
{
    public class HealthCare
    {

        public HealthCare()
        {
            Console.WriteLine("Medical examination information");
        }

        public DateTime Date { get; set; }
        public string Notes { get; set; }
        public string GetInfo
        {
            get
            {
                string info = $"{this.Date.ToLongDateString()}\t Notes: {this.Notes}";
                return info;
            }
        }

    }
}
