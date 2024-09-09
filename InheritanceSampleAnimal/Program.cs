//// See https://aka.ms/new-console-template for more information
////Console.WriteLine("Hello, World!");

//using InheritanceSampleAnimal;

////Dog dog = new Dog();

//Animal animal = new Animal();
//animal.Age = 2;
//animal.Birthdate = DateTime.Now.AddYears(-2);
//animal.FootCount = 4;
//animal.Weight = 10;

//animal.Eat();
//int runResult = animal.Run(2, 500, out int calories);
//TimeSpan restResult = animal.Rest(DateTime.Now, DateTime.Now.AddMinutes(20));

//List<HealthCare> healthCareList = new List<HealthCare>(); // boş liste
//for (int i = 0; i <= 100; i += 15)
//{
//    HealthCare healthCare = new HealthCare();
//    healthCare.Date = DateTime.Today.AddDays(-180).AddDays(i);
//    healthCare.Notes = $"Date: {healthCare.Date.ToString("yyyy-MM-dd")} - {i.ToString()}";
//    healthCareList.Add(healthCare);
//}

//animal.HealthCareHistory = healthCareList;

//Console.WriteLine("--------------- ANIMAL INFO ---------------");
//Console.WriteLine(animal.AnimalInfo);
//Console.WriteLine("--------------- ANIMAL INFO ---------------");

//Console.WriteLine("--------------- DERIVED CLASS: CAT INFO ---------------");
//Cat cat = new Cat();
//cat.FootCount = 4;
//cat.Age = 2;
//cat.Birthdate = new DateTime(2022, 5, 5);
//cat.Weight = 8;
//cat.Eat();
//int runCatResult = animal.Run(2, 400, out int caloriesCat);
//TimeSpan restCatResult = animal.Rest(DateTime.Now, DateTime.Now.AddMinutes(30));
//cat.CatHouse = "A big cat house";
//double catHousePrice = cat.CatHousePrice(HouseType.big);
//cat.HealthCareHistory = healthCareList;
//string catInfo = cat.AnimalInfo;
//catInfo += $"\n" +
//    $"Calories info: {runCatResult} - {caloriesCat}\n" +
//    $"Resting time: {restCatResult}\n" +
//    $"Cat house price: {catHousePrice}";
//Console.WriteLine(catInfo);
//Console.WriteLine("--------------- DERIVED CLASS: CAT INFO ---------------");

#region String Builder vs +=
using System.Text;

string str = string.Empty;
DateTime beginTime = DateTime.Now;
for (int i = 0; i < 100000; i++)
{
    str += i.ToString();
}
DateTime endTime = DateTime.Now;
TimeSpan ts = endTime - beginTime;
Console.WriteLine(ts);

StringBuilder strBuilder = new StringBuilder();
DateTime beginTime2 = DateTime.Now;
for (int i = 0; i < 100000; i++)
{
    strBuilder.Append(i.ToString());
}
DateTime endTime2 = DateTime.Now;
TimeSpan ts2 = endTime2 - beginTime2;
Console.WriteLine(ts2);

#endregion