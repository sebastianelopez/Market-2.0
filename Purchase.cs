using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

namespace TrabajoPractico4
{
    public class Purchase 
    {
        public int id { get; set; }
        public double total { get; set; }
        public List<Product> products { get; set; }
        public User buyer { get; set; }

        public Purchase( double total, User buyer, List<Product> products)
        {            
            this.total = total;
            this.buyer = buyer;
            this.products = products;
        }

        public static String parseProductsOfPurchaseToString(List<Product> products)
        {
            String productId;
            String productList= "";

            foreach (Product product in products )
            {
                productId = product.name.ToString();
                productList += "/" + productId;
            }

            return productList;
        }

    }
}