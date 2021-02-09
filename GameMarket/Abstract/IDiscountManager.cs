using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    interface IDiscountManager
    {
        void Add(Discount discount);
        void Delete(Discount discount);
        void Update(Discount discount);
    }
}
