// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using InheritanceSamplePerson;

Accountant accountant = new Accountant();
accountant.FullName = "John Doe";
accountant.BirthDate = DateTime.Now.AddYears(-35).AddDays(20);
accountant.Gender = true;
accountant.Height = 178;
accountant.Weight= 82;
accountant.HasDrivingLicence = true;
accountant.HasHealthProblem = false;
accountant.Salary = 50000;
accountant.CanViewSalaryInfo = true;
accountant.CanChangeSalaryInfo = true;
accountant.ShowAccountantInfo();

Console.WriteLine(new string('-', 100));

HumanResources humanResources = new HumanResources("Jane Doe", DateTime.Now.AddYears(-32).AddDays(-45), false, 58, 163, false, false, 55000,true, false, true);