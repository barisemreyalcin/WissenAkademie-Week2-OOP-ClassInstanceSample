using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SealedClassSample
{
    public class ContactInformation : Person
    {
        public string Address { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public sealed override string DisplayPersonInfo()
        {
            //return base.DisplayPersonInfo(); // default
            string info =
                $"{base.DisplayPersonInfo()} \n" +
                $"Address: {Address} \n" +
                $"Email: {Email} \n" +
                $"Phone: {Phone}";
            return info;
        }
    }
}
