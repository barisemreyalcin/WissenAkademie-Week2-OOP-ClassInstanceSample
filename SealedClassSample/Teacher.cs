using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassSample
{
    public sealed class Teacher : ContactInformation
    {
        public string Specialization { get; set; }
    }
}
