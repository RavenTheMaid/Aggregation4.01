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
            bool doesThisProductExistAlready = false;
            foreach (Product item in products.Keys)
            {
                if (products.ContainsKey(product))
                {
                    products[item] += amount;
                    doesThisProductExistAlready = true;
                    break;
                }
            }
            if (doesThisProductExistAlready != true)
            {
                products.Add(product, amount);
            }
        }
       
        public Dictionary<Product, int> GetProducts()
        {
            return products;
        }

        public override string ToString()
        {
            string allProducts = "";
            int amountOfProducts = 0;

            //adds each product to the ToString
            foreach (Product product in products.Keys)
            {
                allProducts += $"{product}Amount: {products[product]}\n\n";
                products.TryGetValue(product, out int productAmount);
                amountOfProducts += productAmount;
            }

            return allProducts;
        }
    }

    


    

    
}
