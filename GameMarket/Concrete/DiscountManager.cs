using System;
using System.Collections.Generic;
using System.Text;

namespace GameMarket
{
    class DiscountManager : IDiscountManager
    {
        public void Add(Discount discount)
        {
            Console.WriteLine("Yeni kampanya tanimlandi: " + discount.Name + "," + discount.Value);
            //game.Discount = discount;
            //Console.WriteLine(game.Name + " isimli oyuna "+ discount+" lira indirim yapildi.");
            //Console.WriteLine("Yeni fiyat: "+ (game.Price-game.Discount));
        }

        public void Delete(Discount discount)
        {
            Console.WriteLine("Kampanya kaldirildi: " + discount.Name);
        }


        public void Update(Discount discount)
        {
            Console.WriteLine("Kampanya guncellendi: " + discount.Name + "yeni deger: "+ discount.Value);
        }
    }
}
