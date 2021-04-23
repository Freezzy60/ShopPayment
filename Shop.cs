using System;
using System.Collections.Generic;
using System.Text;

namespace ShopPayment
{
   public class Shop
    {
        public List<Product> products = new List<Product>();
        public string ShopName { get; set; }

        public double ShopCredit { get; set; }

        public Shop(string shopName, double shopCredit)
        {
            this.ShopName = shopName;
            this.ShopCredit = shopCredit;
        }
        public List<IPay> payFunction = new List<IPay>();

        public void ShowProducts()
        {
            int position = 0;
            foreach (var product in products)
            {
                Console.WriteLine($"{position++}.............{product.Name}  EUR[{product.Price}]");
            }
        }
    }
}
