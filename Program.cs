using System;

namespace ShopPayment
{
   public class Program
    {
        static void Main(string[] args)
        {
            Customer person = new Customer("Dennis", 10000.00);
            Shop shop = new Shop("Media Markt", 500000.00);
            
            var cash = new Cash();
            var debitCard = new DebitCard();
            var creditCard = new CreditCard();

            shop.payFunction.Add(cash);
            shop.payFunction.Add(creditCard);
            shop.payFunction.Add(debitCard);
            

            

            var IPhone = new Product("IPhone", 899.99);
            shop.products.Add(IPhone);

            var SPhone = new Product("Samsung Galaxy S21", 699.99);
            shop.products.Add(SPhone);

            var MacBook = new Product("MacBook", 1050.99);
            shop.products.Add(MacBook);

            var AirPods = new Product("AirPods", 114.99);
            shop.products.Add(AirPods);

            var AppleWatch = new Product("Apple Watch", 439.26);
            shop.products.Add(AppleWatch);

            person.BuyProducts(shop);
            Console.WriteLine($"Customer Account Balance:{person.AccountBalance}");
            Console.WriteLine($"Shop Balance{shop.ShopCredit}");
            
        }
    }
}
