internal class Program
{
    private static void Main(string[] args)
    {
        int[] array = new int[5];
        int x;

        for (int i = 0; i < array.Length; i++)
        {
            Console.Write($"Insert {i} value: ");
            x = int.Parse(Console.ReadLine());
        }


        Console.WriteLine("The value that you input");
        foreach (var item in array)
        {
            Console.WriteLine(item);
        }
    }
}