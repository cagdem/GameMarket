using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    public interface ICustomerCheckService
    {
        void CheckIfRealPerson(Customer customer);
    }
}
