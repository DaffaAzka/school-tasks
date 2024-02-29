internal class Program
{
    private static void Main(string[] args)
    {
        int[,] arr = new int[3,5];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write($"Masukan input arr[{i}, {j}] : ");
                arr[i, j] = int.Parse(Console.ReadLine());

            }
            Console.WriteLine("");
        }

        Console.WriteLine("==========================");
        Console.WriteLine("Tabel Angka");
        Console.WriteLine("==========================");
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                Console.Write(arr[i, j]);
                Console.Write("     ");

            }
            Console.WriteLine("");
        }

        // Mencari value minimum dan maximal
        int min = arr[0, 0];
        int max = arr[0, 0];

        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                if (arr[i,j] > max)
                {
                    max = arr[i, j];
                }

                if (arr[i, j] < min)
                {
                    min = arr[i, j];
                }

            }
        }
        Console.WriteLine("==========================");
        Console.WriteLine($"Maximum value: {max}");
        Console.WriteLine($"Minimum value: {min}");
        Console.WriteLine("==========================");

        //Mencari total dan rata-rata
        int total = 0;
        for (int i = 0; i < 3; i++)
        {
            for (int j = 0; j < 5; j++)
            {
                total += arr[i, j];
            }
        }
        double avarage = total / 15;

        Console.WriteLine($"Total value: {total}");
        Console.WriteLine($"Avarage value: {avarage}");
        Console.WriteLine("==========================");
    }
}