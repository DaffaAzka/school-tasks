internal class Program
{
    private static void Main(string[] args)
    {
        int[] arr = new int[5];

        arr[0] = 1;
        arr[1] = 40;
        arr[2] = 12;
        arr[3] = 89;
        arr[4] = 16;

        foreach (var item in arr)
        {
            Console.WriteLine($"Item: {item}")
        }
    }
}