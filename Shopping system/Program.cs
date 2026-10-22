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
                
                if(guy1.Subscription == "basic")

                Console.WriteLine(guy1.ToString());

            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }

        
    }
}
