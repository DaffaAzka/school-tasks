internal class Program
{
    private static void Main(string[] args)
    {
        var i = 5;
        var j = 30;
        var k = 1;

        while(i <= 26)
        {
            Console.WriteLine($"{i} {j}");
            i += k;
            j -= k;
            k++;
        }
    }
}