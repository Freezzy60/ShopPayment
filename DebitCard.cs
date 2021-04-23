using System;
using System.Collections.Generic;
using System.Text;

namespace ShopPayment
{
    public class DebitCard : IPay
    {
        public string Name { get; set; } = "Debit Card";

        public double Pay(double price, double accountBalace)
        {
          return  accountBalace = accountBalace - price;        

        }

        public double APay(double price, double shopCredit)
        {
            return shopCredit = shopCredit + price;
        }
    }
}
