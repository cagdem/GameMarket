using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    interface IMarketManager
    {
        void Buy(Game game, Customer customer);
    }
}
