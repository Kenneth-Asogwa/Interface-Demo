using InterfaceLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<IProduct> shop = AddSampleData();
            
            Customer cust = GetCustomer();

            foreach (IProduct prod in shop)
            {
                prod.SendItem(cust);
                if(prod is IDigitalModel digital)
                {
                    Console.WriteLine($"For the shopping of {digital.Title} you have {digital.TotalBalanceLeft} balance left.");
                }
            }


            Console.ReadLine();

        }

        //create a get method that contains customers information and populate it
        //as a static method you can use the getcustomer method inside the main method
        //define the get method
        private static Customer GetCustomer()
        {
            //populate it
            return new Customer
            {
                FirstName = "Kenneth",
                LastName = "Asogwa",
                Address = "20 Jogunosinmi Street, Alausa",
                City = "Ikeja",
                Email = "kennethasogwa69@gmail.com",
                PhoneNumber = "07064713569"
            };
        }
        //create a generic method
        private static List<IProduct> AddSampleData()
        {

            List<IProduct> result = new List<IProduct>();

            result.Add(new Product { Title = "an Iphone 12 Pro" });
            result.Add(new Product { Title = "a Google T-Shirt" });
            result.Add(new Product { Title = "a brand new Car" });
            result.Add(new DigitalModel { Title = "C# textbook" });
            result.Add(new CourseProductModel { Title = ".NET Core crash" });

            return result;
        }
        

    }
}
