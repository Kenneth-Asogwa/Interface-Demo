using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace InterfaceLibrary
{
    public  interface IProduct
    {
         string Title { get; set; }

         //property signature
         bool HasPaymentBeenMade { get; }

         // method signature
         void SendItem(Customer cust);
    }
}
