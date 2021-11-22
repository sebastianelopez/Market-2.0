using System;
using System.Collections.Generic;
using System.Text;

namespace TrabajoPractico4
{
    public class Cart
    {
        public int id { get; set; }

        public User user { get; set; }

        public int userId { get; set; }
        public List<Product> products { get; set; }

        public List<CartProduct> CartProducts { get; set; }

        public Cart(int id, List<Product> products)
        {
            this.id = id;
            this.products = products;
        }

        public void AddNewProduct(Product product)
        {
            products.Add(product);
        }

        public override string ToString()
        {
            return "\nCart: " +
                "\nId: " + id + " - " +
                "Products: " + products;
        }

        public static string parseCartToString(Cart cart)
        {
            return cart.id.ToString();
        }
    }
}