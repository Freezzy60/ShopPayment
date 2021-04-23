using System;
using System.Collections.Generic;
using System.Text;

namespace ShopPayment
{
   public class Customer
    {
        public string Name { get; set; }

        public double AccountBalance { get; set; }

        public Customer(string name, double accountBalance)
        {
            this.Name = name;
            this.AccountBalance = accountBalance;
        }

        

        public void BuyProducts(Shop shop)
        {
            var summe = 0.0;
            var sCart = new List<Product>();

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Products");
                shop.ShowProducts();
                Console.WriteLine($"z............. for pay");
               var input =  int.TryParse(Console.ReadLine(),out int result);
                if (input)
                {
                    sCart.Add(shop.products[result]);
                }
                else
                {
                    break;
                }
            }
            Console.Clear();
            Console.WriteLine("PAYMENT OPTIONS");
            int position = 0;
            foreach (var payMethoden in shop.payFunction)
            {
                Console.WriteLine($"{position++}.............{payMethoden.Name}");
            }
            int selection = int.Parse(Console.ReadLine());
            var selectedpayFun = shop.payFunction[selection];
            foreach (var item in sCart)
            {
                summe += item.Price; 
            }


            AccountBalance = selectedpayFun.Pay(summe, AccountBalance);

            shop.ShopCredit = selectedpayFun.APay(summe, shop.ShopCredit);
            Console.WriteLine(summe);
        }

    }
}
