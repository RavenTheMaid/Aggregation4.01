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
       
        public decimal CalculatePrice(string subscription)
        {
            decimal priceWithTax = 0m;
            int amountOfProducts = 0;
            //the tax is most definitely included in the final price of all products
            foreach (Product product in products.Keys)
            {

                products.TryGetValue(product, out amountOfProducts);
                priceWithTax += product.Price * amountOfProducts;
            }
            if (subscription == "premium")
            {
                priceWithTax *= 0.9755m;
            }
            else if (subscription == "gold")
            {
                priceWithTax *= 0.9375m;
            }
            return priceWithTax;
        }
        public  decimal CalculatePriceWithoutTax(decimal price, decimal tax)
        {
            decimal realTax = 1m - tax; 
            return price * realTax;
        }

        public override string ToString()
        {
            string test = "";
            decimal totalPriceWithoutTax = 0m;
            decimal totalPriceWithTax = 0m;
            int amountOfProducts = 0;
            
            foreach (Product product in products.Keys)
            {
                test += $"{product}Amount: {products[product]}\n\n";
                products.TryGetValue(product, out int productAmount);
                amountOfProducts += productAmount;
            }

            totalPriceWithTax += CalculatePrice();
            totalPriceWithoutTax += CalculatePriceWithoutTax(totalPriceWithTax, 0.3m);
            
            test += $"" +
                $"Total amount of products: {amountOfProducts}\n" +
                $"Price with tax:{totalPriceWithTax:C2}\n" +
                $"Price without tax: {totalPriceWithoutTax:C2}";

            return test;
        }
    }

    


    

    
}
