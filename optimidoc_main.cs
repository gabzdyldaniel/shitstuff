using ConsoleApp7;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp28
{
    class Program
    {
        public static List<Customer> customerList = new List<Customer>() { };

        static void Main(string[] args)
        {
            Customer customer = new Customer("12345", 1);
            customerList.Add(customer);
            Customer customer2 = new Customer("31323341", 2);
            customerList.Add(customer2);
            Customer customer3 = new Customer("123456", 3);
            customerList.Add(customer3);
            Customer customer4 = new Customer("12345678", 4);
            customerList.Add(customer4);
            Customer customer5 = new Customer("123456", 5);
            customerList.Add(customer5);
            Customer customer6 = new Customer("1E240", 6);
            customerList.Add(customer6);

            foreach (Customer cust in customerList)
            {
                Console.WriteLine(Customer.ValidateCustomer(cust));
            }

            Console.ReadKey();
        }
    }
}
