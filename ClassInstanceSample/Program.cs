// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World)!";

#region Animal
using ClassInstanceSample;

//Animal animal = new Animal();
//Animal animalType = new Animal("Bird");

//// Eskiden
////animal.setAnimalType("Reptiles");
////Console.WriteLine(animal.getAnimalType()); // Reptiles dönderir

//// Yeni
//animal.AnimalType = "Reptiles"; // set çalışır
//Console.WriteLine(animal.AnimalType); // get çalışır (Reptiles dönderir)

//animal.Speed = 100;
//Console.WriteLine(animal.Speed); // 100

//Yıkıcı method için
//for (int i = 0; i < 100000; i++)
//{
//    Animal animal1 = new Animal();
//    animal1 = null;

//    GC.Collect(); // Garbage collecter çağırabilirim
//}
#endregion

#region Iron
//Iron iron = new Iron();

//iron.Brand = "Rowenta";
//iron.Temperature = 0;
//iron.Color = "Gray";
//iron.HasSteamGenerator = true;

//string ironInfo =
//    $"This iron has following information\n" +
//    $"Brand: {iron.Brand}\n" +
//    $"Color: {iron.Color}\n" +
//    $"Temperature: {iron.Temperature}\n" +
//    $"Steam Generator: {(iron.HasSteamGenerator ? "Present" : "Absent")}";

//Console.WriteLine(ironInfo);

//Console.WriteLine(new string('*', 50));

//Iron iron2 = new Iron("Sundu", "Red", 0, true);

//Console.WriteLine(new string('*', 50));

//Iron ironBrand = new Iron("Philips");
//ironBrand.Color = "White";
//ironBrand.Temperature = 10;
//ironBrand.HasSteamGenerator = false;

//Console.WriteLine(new string('*', 50));

//Iron newIron = new Iron()
//{
//    Brand = "Braun",
//    Color = "Orange",
//    Temperature = 0,
//    HasSteamGenerator = true,
//};

//newIron.HeatUp(45);
#endregion

#region Person
// Default olarak her sınıfın bir ToString() methodu vardır
Person person = new Person();
person.FirstName = "Jax";
person.LastName = "Teller";
person.Gender = "Male";
person.BirtDate = DateTime.Now.AddYears(-46);
person.Email = "jaxteller@contoso.com";
person.Phone = "555-555-55-55";
person.Address = "TM (Teller-Morrow) Auto Repair, Charming, CA";

//string personInfo = person.ToString(); // Burada yapacağım şeyi arkada yaparak abstract etmiş oldum
string personInfo = person.GetPersonInfo; 
Console.WriteLine(personInfo);
#endregion