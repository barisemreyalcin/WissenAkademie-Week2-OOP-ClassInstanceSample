using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassSample
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public bool Gender { get; set; }
        public int Age { get; set; }

        public virtual string DisplayPersonInfo()
        {
            string info =
                   $"Full Name: {FirstName} {LastName} \n" +
                   $"Gender: {(Gender ? "Male" : "Female")}\n" +
                   $"Age: {Age}";
            return info;
        }
    }
}
