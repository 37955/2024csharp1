namespace HelloWorld
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Green;

            string helloWorld = "Hello, World!";
            for (int i = 0; i < helloWorld.Length; i++)
            {
                Console.Write(helloWorld[i]);
                Thread.Sleep(350);
            }

        }
    }
}
