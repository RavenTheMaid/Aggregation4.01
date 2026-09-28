namespace Shopping_system
{
    internal class Program
    {
        static void Main(string[] args)
        {
            try
            {
                ContactInfo ci = new(51231, "somethingsomething@somethingsomething.com", "12312312");
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
