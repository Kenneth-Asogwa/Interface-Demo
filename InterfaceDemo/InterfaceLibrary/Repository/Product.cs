using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
   public class Product : IProduct
    {
        public string Title { get; set; }

        public bool HasPaymentBeenMade { get; private set; }

        public void SendItem(Customer cust) //an instance of the customer class
        {
            if(HasPaymentBeenMade == false)
            {
                Console.WriteLine($"Simulating shipping {Title} to {cust.FirstName} {cust.LastName} in {cust.Address}, {cust.City}");
                HasPaymentBeenMade = true;
            }
        }

        
    }
}
