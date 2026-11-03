using System;
using System.Collections.Generic;
using System.Text;

namespace Shopping_system
{
    internal class Checkout
    {
        //public Checkout(Basket basket, Customer customer)
        //{
        //    Basket = basket;
        //    Customer = customer;
        //}
        
        //private Basket basket;
        //public Basket Basket
        //{
        //    get
        //    {
        //        return basket;
        //    }
        //    set
        //    {
        //        basket = value;
        //    }
        //}
        //private Customer customer;
        //public Customer Customer
        //{
        //    get
        //    {
        //        return customer;
        //    }
        //    set
        //    {
        //        customer = value;
        //    }
        //}

            public decimal CalculatePrice(Basket basket, Customer customer)
            {   
                decimal priceWithTax = 0m;
                int amountOfProducts = 0;

                Dictionary<Product, int> products = basket.GetProducts();
                //the tax is most definitely included in the final price of all products
                foreach (Product product in products.Keys)
                {
                    products.TryGetValue(product, out amountOfProducts);
                    priceWithTax += product.Price * amountOfProducts;
                }
                if (customer.Subscription == "premium")
                {
                    priceWithTax *= 0.9755m;
                }
                else if (customer.Subscription == "gold")
                {
                    priceWithTax *= 0.9375m;
                }
                return priceWithTax;
            }
        public decimal CalculatePriceWithoutTax(decimal price, decimal tax)
        {
            decimal realTax = 1m - tax;
            return price * realTax;
        }

        //public override string ToString()
        //{
        //    decimal totalPriceWithoutTax = 0m;
        //    decimal totalPriceWithTax = 0m;

        //    totalPriceWithTax += CalculatePrice(customer.Subscription);
        //    totalPriceWithoutTax += CalculatePriceWithoutTax(totalPriceWithTax, 0.3m);
        //    return $"Total price: {totalPriceWithTax}\n" +
        //           $"Total price without tax: {totalPriceWithoutTax}";
        //}

    }
}
