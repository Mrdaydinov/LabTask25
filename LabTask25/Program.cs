namespace LabTask25
{
    internal class Program
    {
        static void Main(string[] args)
        {
            IProduct[] products = { new Book("book1", 100, 10), new Electronic("electronic1", 200, 6) };

            foreach (var product in products)
            {
                Console.WriteLine("Price = " + product.GetPrice());
             
                Random r = new Random();
                int value = r.Next(1, 5);
                product.ReduceStock(value);

                Console.WriteLine("Price = " + product.GetPrice());
            }
        }
    }
}
