using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassInstanceSample
{
    public class Person
    {
        /* ACCESS MODIFIERS - ERİŞİM BELİRLEYİCİLER
         * private: Aynı class içerisinde erişilebilen variables, fields, methods ve functions tanımlamak için kullanılır
         * internal: Aynı solution içerisinde erişilebilen variables, fields, methods ve functions tanımlamak için kullanılır
         * protected: Inherit edilerek kullanılan classlarda erişilebilen variables, fields, methods ve functions tanımlamak için kullanılır
         * public: Genel her projeden erişilebilen variables, fields, methods ve functions tanımlamak için kullanılır
         * internal protected: Aynı solution içerisinde inherit edilerek kullanılan classlarda erişilebilen variables, fields, methods ve functions tanımlamak için kullanılır
         */

        // birden çok constructor: overload methodlar, yani aynı methodu farklı parametrelerle isteğime göre kullanmak
        public Person() {
            string text = "Person Class initialized";
            Console.WriteLine(text);
        }

        public Person(string _firstName) // local veya method değişkenlerde _ kullanabilirsin
        {
            string text = $"Person Class initialized with {_firstName}";
            Console.WriteLine(text);
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName // read only property (set: write only)
        {
            get
            {
                return $"{this.FirstName} {this.LastName}";
            }
        }
        public DateTime BirtDate { get; set; }
        public string Gender { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }

        public override string ToString() // override etme Polymorphism ile ilişkili
        {
            //return base.ToString(); // her class default methodlara sahip bunlardan biri ToString, işte biz bunu isteğimize göre override edeceğiz
            // base: bu sınıf nereden türediyse o sınıfı temsil eder
            // this: direkt üzerinde işlem yaptığımız sınıfı temsil eder

            string personInfo =
                $"Full Name: {this.FullName}\n" +
                $"Gender: {this.Gender}\n" +
                $"Birth Date: {this.BirtDate}\n" +
                $"Email: {this.Email}\n" +
                $"Phone: {this.Phone}\n" +
                $"Address: {this.Address}";
            return personInfo;
        }

        // Veya aşağıdaki gibi bir read only property yazabilirim, içerdeki field'ı encapsule eden bir property
        private string _personInfo; // field

        public string GetPersonInfo
        {
            get { 
                _personInfo =
                    $"Full Name: {this.FullName}\n" +
                $"Gender: {this.Gender}\n" +
                $"Birth Date: {this.BirtDate}\n" +
                $"Email: {this.Email}\n" +
                $"Phone: {this.Phone}\n" +
                $"Address: {this.Address}";
                return _personInfo;
            }
        }
    }
}
