using System;
using System.Collections.Generic;
using System.Text;

namespace ShopPayment
{
   public class Cash : IPay
    {
        public string Name { get; set; } = "Cash";
        public double Pay(double price, double accountBalace)
        {
            return accountBalace = accountBalace - price;
            
        }
      public double APay(double price, double shopCredit)
        {
            return shopCredit = shopCredit + price;
        }
    }
}
