using System;

namespace GameMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer customer = new Customer { Id = 1, FirstName = "Caglar", LastName = "Demir", TcNo = "12413241425", BirthDate = "1995" };
            Game game = new Game { Name = "CS:Go", Price = 25 };

            CustomerManager customerManager = new CustomerManager(new CustomerCheckManager());
            MarketManager marketManager = new MarketManager();
            DiscountManager discountManager = new DiscountManager();

            customerManager.Add(customer);
            customerManager.Update(customer);
            customerManager.Delete(customer);
            Console.WriteLine();
            marketManager.Buy(game, customer);
            Console.WriteLine();
            Discount discount = new Discount { Name = "kis indirimi", Value = 10 };
            Console.WriteLine();
            marketManager.Buy(game, customer,discount);

        }
    }
}
