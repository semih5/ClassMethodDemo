using System;

namespace ClassMethodDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer1 = new Customer();
            customer1.Id = 001;
            customer1.CustomerName = "Semih";
            customer1.Balance = 1200;

            Customer customer2 = new Customer();
            customer2.Id = 002;
            customer2.CustomerName = "Customer2";
            customer2.Balance = 3000;

            Customer customer3 = new Customer();
            customer3.Id = 003;
            customer3.CustomerName = "Customer3";
            customer3.Balance = 1234;

            Customer[] customers = new Customer[]
            {
                customer1,customer2,customer3
            };


            // Getting the customer list.
            for (int i = 0; i < customers.Length; i++)
            {
                Console.WriteLine("Customer Name: " + customers[i].CustomerName + ". " + "Customer ID: " + customers[i].Id + "." + "\n");
            }

            // An alternative way to getting the customer list.
            //foreach (var customer in customers)
            //{
            //    Console.WriteLine("Customer Name: "+customer.CustomerName+". "+"Customer ID: "+customer.Id+"."+"\n");
            //}

            CustomerManager CustomerManager = new CustomerManager();


            Console.WriteLine("--------------------");

            //Add Customer
            CustomerManager.AddCustomer(customer1);
            Console.WriteLine("--------------------");

            //Delete Customer
            CustomerManager.DeleteCustomer(customer2);
            Console.WriteLine("--------------------");

            //List Customer
            CustomerManager.CustomerList(customer3);
            

        }
    }
}
