using System;
using System.Collections.Generic;
using System.Text;

namespace ShopPayment
{
   public interface IPay
    {
        public string Name { get; set; } 

        public double Pay(double price, double accountBalace);

        public double APay(double price, double shopCredit);
    }
}
