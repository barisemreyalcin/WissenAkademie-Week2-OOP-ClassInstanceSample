using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSampleAnimal
{
    public class Animal
    {
        #region Constructors
        public Animal()
        {
            Console.WriteLine("The class that has common properties");
        }
        #endregion

        #region Properties
        public int FootCount { get; set; }
        public int Age { get; set; }
        public DateTime Birthdate { get; set; }
        public List<HealthCare> HealthCareHistory { get; set; }
        public double Weight { get; set; }
        public string AnimalInfo
        {
            get
            {
                string info =
                    $"Foot count: {FootCount} \n" +
                    $"Age: {Age} \n" +
                    $"Weight: {Weight} \n" +
                    $"Health Care History: {ListHealthCareHistory(HealthCareHistory)}";
                return info;
            }
        }

        #endregion

        #region Procedures (Methods)
        // ListHealthCareHistory private yaptık çünkü sadece yukardaki kısımda string birleştirmesi için kullanıyoruz
        private string ListHealthCareHistory(List<HealthCare> healthCareHistory)
        {
            // + ile string birleştirirken kaç tane birleştirme yaparsam heap'te o kadar alan açar. Bu gereksiz. Bunun yerine StringBuilder kullanırız. Aynı alanı update eder. Daha iyi performans açısından
            StringBuilder str = new StringBuilder();
            foreach (HealthCare hc in healthCareHistory)
            {
                str.Append($"{hc.Date.ToString("yyyy-MM-dd")} - {hc.Notes}; ");
            }

            return str.ToString();
        }
        public void Eat()
        {
            Console.WriteLine("Animal eats");
        }

        public int Run(int minute, int distance, out int calories)
        {
            calories = minute * distance / 100;
            int result = minute * distance;
            return result;
        }

        public TimeSpan Rest(DateTime beginDate, DateTime endDate)
        {
            TimeSpan result = endDate.Subtract(beginDate);
            return result;
        }
        #endregion

    }
}
