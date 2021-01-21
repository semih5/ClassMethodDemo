using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMethodDemo
{
    class CustomerManager
    {     //
        public void CustomerList(Customer customer)
        {
            Console.WriteLine("Customer List: "+"\n"+"Id: "+ customer.Id+". "+"Name :"+customer.CustomerName+". "+"Balance: "+customer.Balance);
        }
        public void AddCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName+" was added. "+"ID: "+customer.Id);
        }
        
        public void DeleteCustomer(Customer customer)
        {
            Console.WriteLine(customer.CustomerName+" was deleted. "+"ID: " + customer.Id);
        }
                
    }
}
