using System;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer();
            customer.Name = "Test";
            customer.Address = "İstanbul";

            CustomerManger customerManger = new CustomerManger();
            customerManger.Add(customer);
            customerManger.Update(customer);
        }
    }
}
