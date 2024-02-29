internal class Program
{
    private static void Main(string[] args)
    {
        char input;

        Console.WriteLine("Menu Makanan");
        Console.WriteLine("========================");
        Console.WriteLine("1. Nasi Remes");
        Console.WriteLine("2. Nasi Pecel");
        Console.WriteLine("3. Nasi Padang");
        Console.WriteLine("4. Nasi Kucing");
        Console.WriteLine("5. Keluar");
        Console.WriteLine("========================");
        Console.Write("Pilihan [1-5]: ");
        input = Console.ReadLine()[0];

        switch (input)
        {
            case '1': Console.WriteLine("Anda memilih nasi remes"); break;
            case '2': Console.WriteLine("Anda memilih nasi pecel"); break;
            case '3': Console.WriteLine("Anda memilih nasi padang"); break;
            case '4': Console.WriteLine("Anda memilih nasi kucing"); break;
            case '5': Console.WriteLine("Anda Keluar"); break;
            default: Console.WriteLine("Anda tidak memilih apapun"); break;
        }
        
    }
}