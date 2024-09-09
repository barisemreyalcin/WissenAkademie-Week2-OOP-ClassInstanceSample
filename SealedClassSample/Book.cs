using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassSample
{
    // sealed keyword: kenidisinden instance alınabilir ama inherit edilemez anlamına gelir
    public sealed class Book : BaseBook
    {
        public int Id { get; set; }
        public string BookName { get; set; }
        public string BookGenre { get; set; }
        public string ISBN { get; set; }
        public string Author { get; set; }

        // Polymorphism kavramı ile ilgili
        // override yazarak da virtual olan methodlar override edilmek üzere ilgili derived class'a gelir. İster override ederim ister etmem. Default zaten base'deki halidir.
        public override void GetLog()
        {
            //base.GetLog();
            Console.WriteLine("GetLog method of derived Book Class");
        }

        public override void GetUser()
        {
            //base.GetUser();
            Console.WriteLine("GetUser method of derived Book Class");
        }

    }
}
