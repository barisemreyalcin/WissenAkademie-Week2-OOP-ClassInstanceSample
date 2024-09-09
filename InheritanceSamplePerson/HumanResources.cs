using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSamplePerson
{
    public class HumanResources : Human
    {
        public bool CanHire { get; set; }
        public bool CanSpecifySalary { get; set; }
        public bool CanArrangeWorkingHours { get; set; }

        public HumanResources(string fullName, DateTime birthDate, bool gender, double weight, double height, bool hasDrivingLicence, bool hasHealthProblem, decimal salary, bool canHire, bool canSpecifySalary, bool canArrangeWorkingHours)
        {
            FullName = fullName;
            BirthDate = birthDate;
            Gender = gender;
            Weight = weight;
            Height = height;
            HasDrivingLicence = hasDrivingLicence;
            HasHealthProblem = hasHealthProblem;
            Salary = salary;
            CanHire = canHire;
            CanSpecifySalary = canSpecifySalary;
            CanArrangeWorkingHours = canArrangeWorkingHours;

            DisplayInfo();
        }

        private void DisplayInfo()
        {
            string info =
                 $"Some information about one of our human resources personnels, {FullName}: \n" +
                 $"Birthdate: {BirthDate} \n" +
                 $"Gender: {(Gender ? "Male" : "Female")} \n" +
                 $"Height: {Height} - Weight: {Weight}\n" +
                 $"{FullName} {(HasDrivingLicence ? "has" : "doesn't have")} a driving licence\n" +
                 $"{FullName} {(HasDrivingLicence ? "has" : "doesn't have")} a health problem\n" +
                 $"Salary: {Salary}\n" +
                 $"Authorization: \n" +
                 $"{FullName} {(CanHire ? "can" : "cannot")} hire new personnels for company\n" +
                 $"{FullName} {(CanSpecifySalary ? "can" : "cannot")} specify salaries\n" +
                 $"{FullName} {(CanArrangeWorkingHours ? "can" : "cannot")} arrange working hours";
            Console.WriteLine(info);
        }
    }
}
// Bazı class'ları türetmek amaçlı kullanmak istemeyebilirim. Bu durumda "sealed" keyword'ü kullanırım. Böylece sadece instance alarak kullanırım bu class'ı.
