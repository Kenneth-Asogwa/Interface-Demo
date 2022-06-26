using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceLibrary
{
   public class DigitalModel : IProduct, IDigitalModel
    {
        public string Title { get; set; }

        public bool HasPaymentBeenMade { get; private set; }

        public decimal TotalBalanceLeft { get; private set; } = 500.46M;

        public void SendItem(Customer cust)
        {
            Console.WriteLine($"Simulating emailing {Title} to {cust.Email}");
            TotalBalanceLeft -= 100;

            if(TotalBalanceLeft < 1)
            {
                HasPaymentBeenMade = true;
                TotalBalanceLeft = 0;
            }
        }
    }
}
