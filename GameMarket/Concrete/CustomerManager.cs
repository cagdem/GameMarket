using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class CustomerManager : ICustomerManager
    {
        private ICustomerCheckService _customerCheckService;

        public CustomerManager(ICustomerCheckService customerCheckService)
        {
            _customerCheckService = customerCheckService;
        }
        public void Add(Customer customer)
        {
            _customerCheckService.CheckIfRealPerson(customer);
            Console.WriteLine("Musteri eklendi.");
        }

        public void Delete(Customer customer)
        {
            Console.WriteLine("Musteri silindi.");
        }

        public void Update(Customer customer)
        {
            Console.WriteLine("Musteri guncellendi.");
        }
    }
}
