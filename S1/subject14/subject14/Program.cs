internal class Program
{
    private static void Main(string[] args)
    {
        var i = 3; 
        var j = 60;

        while (i <= 15)
        {
            Console.WriteLine($"{i} {j}");
            i += 3;
            j++;
        }

        Console.WriteLine("Thanks");
    }
}