using System;
using System.Collections.Generic;
using System.Text;

namespace ShopPayment
{
    public class CreditCard : IPay
    {
        public string Name { get; set; } = "Credit Card";

        public double Pay(double price, double accountBalace)
        {
           return accountBalace = accountBalace - price;
            
        }
        public double APay(double price, double shopCredit)
        {
            return shopCredit = shopCredit + (price - (price / 100 * 3));
        }

    }
}
