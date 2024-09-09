using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSamplePerson
{
    public class Accountant : Human
    {
        public bool CanViewSalaryInfo { get; set; }
        public bool CanChangeSalaryInfo{ get; set; }

        public void ShowAccountantInfo()
        {
            string info =
                $"Some information about one of our accounting personnels, {FullName}: \n" +
                $"Birthdate: {BirthDate} \n" +
                $"Gender: {(Gender ? "Male" : "Female")} \n" +
                $"Height: {Height} - Weight: {Weight}\n" +
                $"{FullName} {(HasDrivingLicence ? "has" : "doesn't have")} a driving licence\n" +
                $"{FullName} {(HasDrivingLicence ? "has" : "doesn't have")} a health problem\n" +
                $"Salary: {Salary}\n" +
                $"Authorization: \n" +
                $"{FullName} {(CanViewSalaryInfo ? "can" : "cannot")} view salary info\n" +
                $"{FullName} {(CanChangeSalaryInfo ? "can" : "cannot")} change salary info";
            Console.WriteLine(info);
        }
    }
}
