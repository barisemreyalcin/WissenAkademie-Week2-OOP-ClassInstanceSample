using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassSample
{
    public class BaseBook
    {
        public DateTime CreationDate {  get; set; }
        public DateTime UpdateDate {  get; set; }

        // Derived class'ta farklı bir işlem yapmasını istiyorsam virtual keyword eklerim yani istersem override ederim istersem etmem demektir. Eklemek zorunda değilim.
        public virtual void GetLog() {
            Console.WriteLine("Record has started...");
        }
        public virtual void GetUser()
        {
            Console.WriteLine("User information is being retrieved...");
        }
    }
}
