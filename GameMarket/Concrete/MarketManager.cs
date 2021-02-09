using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class MarketManager : IMarketManager
    {
        public void Buy(Game game, Customer customer)
        {
            Console.WriteLine(customer.FirstName +" "+ game.Name + " adli oyunu "+ (game.Price - game.Discount)+"tl fiyata aldi.");
        }
        public void Buy(Game game, Customer customer, Discount discount)
        {
            int newprice;
            Console.WriteLine(customer.FirstName+ " " + discount.Name + " indirimini kullandi.");
            newprice = game.Price - discount.Value;
            Console.WriteLine(game.Name + " icin yeni fiyat: "+ newprice);
        }
    }
}
