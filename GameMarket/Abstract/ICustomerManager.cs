using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    public interface ICustomerManager
    {
        void Add(Customer customer);
        void Update(Customer customer);
        void Delete(Customer customer);
    }
}
