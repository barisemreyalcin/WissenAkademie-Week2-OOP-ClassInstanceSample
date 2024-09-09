using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassSample
{
    // Sealed methodlar override edilemez
    public class Student : ContactInformation
    {
        // override dedikten sonra DisplayPersonInfo methodunu artık göremeyiz çünkü ContactInformation class'ında onu sealed olarak işaretledik. Fakat tabi ki kullanabiliriz.
        public Student()
        {
            DisplayPersonInfo();
        }
    }
}
