namespace Shopping_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                //i dont know how to stop someone from doin @.com
                ContactInfo ci = new(51231, "somethingsomething@somethingsomething.com", "12312312");
                Product product1 = new(123, "theNameOfTheProduct", 500.55m);
                List<Product> productList = new();
                productList.Add(product1);

                Supplier sup = new(32323, "firstname lastname", ci, productList);
                Console.WriteLine(sup.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            try
            {
                ContactInfo ci = new(51231, "somethingsomething@.com", "12312312");
                Supplier sup = new(32323, "firstname lastname", ci);
                Console.WriteLine(sup.ToString());
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
