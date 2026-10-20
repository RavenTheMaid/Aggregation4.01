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
                Basket basket = new();

                basket.AddProduct(product1, 10);
                basket.AddProduct(product2, 1);
                basket.AddProduct(product1, 3);

                decimal totalPrice = CalculatePrice(basket);
                decimal totalPriceWithoutTax = CalculatePriceWithoutTax(totalPrice, 0.30m);

                Customer sup = new(32323, "firstname lastname", ci);
                Console.WriteLine(sup.ToString());
                Console.WriteLine($"" +
                    $"Total price: {totalPrice}\n" +
                    $"Total price without tax: {totalPriceWithoutTax}");
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            //try
            //{
            //    ContactInfo ci = new(51231, "somethingsomething@.com", "12312312");
            //    Supplier sup = new(32323, "firstname lastname", ci);
            //    Console.WriteLine(sup.ToString());
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine(e.Message);
            //}
        }
        public static decimal CalculatePrice(Dictionary<Product, int> basket)
        {
            decimal priceWithTax = 0m;
            //the tax is most definitely included in the final price of all products
            foreach (Product product in basket.Keys)
            {
                priceWithTax += product.Price;
            }
            return priceWithTax;
        }
        public static decimal CalculatePriceWithoutTax(decimal price, decimal tax)
        {
            return price / tax;
        }
    }
}
