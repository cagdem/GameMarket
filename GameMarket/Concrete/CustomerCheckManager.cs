using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    public class CustomerCheckManager : ICustomerCheckService
    {
        public void CheckIfRealPerson(Customer customer)
        {
            Console.WriteLine(customer.FirstName + " isimli kisi gercektir.");
        }
    }
}
