using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
    public class CourseProductModel : IProduct
    {
        public string Title { get; set ; }

        public bool HasPaymentBeenMade { get; private set; }

        public void SendItem(Customer cust)
        {
           if(HasPaymentBeenMade == false)
            {
                Console.WriteLine($"Added the {Title} course to {cust.FirstName}'s account");
                HasPaymentBeenMade = true;
            }
        }
    }
}
