internal class Program
{
    private static void Main(string[] args)
    {
        Task2();
    }

    private static void Example()
    {
        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine($"Loop-{i + 1}");
        }
        Console.WriteLine("Thanks");
    }

    private static void Task1() {

        for (int i = 50; i >= 40; i--)
        {
            Console.WriteLine($"Loop-{i}");
        }
        Console.WriteLine("Thanks");

    }

    private static void Task2()
    {

        for (int i = 31; i <= 40; i +=2)
        {
            Console.WriteLine($"Loop-{i}");
        }
        Console.WriteLine("Thanks");

    }
}