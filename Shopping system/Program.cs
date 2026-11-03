using System.Runtime.CompilerServices;

namespace Shopping_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //i dont know how to stop someone from doin @.com
                ContactInfo ci = new("somethingsomething@kljklj.com", "12312312");
                Product product1 = new("theNameOfTheProduct", 500.55m);
                Product product2 = new("theNameOfTheOtherProduct", 121.63m);
                Product product3 = new("theNameOfTheLastProduct", 150.63m);

                Basket basket = new();

                basket.AddProduct(product1, 10);
                basket.AddProduct(product2, 1);
                basket.AddProduct(product1, 3);
                basket.AddProduct(product3, 20);

                Customer guy1 = new("firstname lastname", ci, "basic", basket);



                Console.WriteLine(guy1.ToString());
                Console.WriteLine(Checkout(basket, guy1));

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        public static string Checkout(Basket basket, Customer customer)
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
            //i decided tax is 30% cause yeah, can be changed
            decimal priceWithoutTax = priceWithTax * 0.7m;

            return $"Total price: {priceWithTax}\n" +
                   $"Total price without tax: {priceWithoutTax}";
        }
    }
}
