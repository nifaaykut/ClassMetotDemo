using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    internal class CustomerManger
    {
        public void Add(Customer customer)
        {
            Console.WriteLine("Müşteri Eklendi : "+ customer.Name );
        }
        public void Update(Customer customer) 
        {
            Console.WriteLine("Müşteri Adresi güncellendi : "+ customer.Address );
        }

    }
}
