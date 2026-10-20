using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_system
{
    internal class Basket
    {
        private Dictionary<Product, int> products = new();


         public void AddProduct(Product product, int amount)
         {
            foreach (Product item in products.Keys)
            {
                if (products.ContainsKey(product))
                {
                    products[item] += amount;
                    break;
                }
                else
                {
                    products.Add(product, amount);
                }
            }
            
         }
        public override string ToString()
        {
            string test = "";
            foreach (Product product in products.Keys)
            {
                    test += $"{product} {products[product]}\n";
            }
            return test;
        }
    }

    


    

    
}
