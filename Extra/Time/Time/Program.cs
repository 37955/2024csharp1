namespace Time
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Clear();
                Console.WriteLine(DateTime.Now.ToLongTimeString());
                Thread.Sleep(1000);
            }
        }
    }
}
