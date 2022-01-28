namespace ConsoleUI
{
    public class MessageManager
    {
        public static void StartApplication()
        {
            Console.WriteLine("Welcome to my application!");
        }

        public static void EndApplication()
        {
            Console.WriteLine("Type enter to close...");
            Console.ReadLine();
        }
    }
}
