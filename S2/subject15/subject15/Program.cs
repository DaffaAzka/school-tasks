using subject15.Objects;

internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("=========================");
            Console.WriteLine("Akses Object");
            Console.WriteLine("=========================");
            Console.WriteLine("1. Luas Lingkaran");
            Console.WriteLine("2. Luas Persegi Panjang");
            Console.WriteLine("3. Volume Balok");
            Console.WriteLine("=========================");
            var s = input();
            Console.WriteLine("=========================");

            if (s == "1")
            {
                LuasLingkaran luasLingkaran = new LuasLingkaran();
                luasLingkaran.input();
                luasLingkaran.process();
                luasLingkaran.output();
            } else if (s == "2")
            {
                LuasPersegiPanjang luasPersegiPanjang = new LuasPersegiPanjang();
                luasPersegiPanjang.input();
                luasPersegiPanjang.process();
                luasPersegiPanjang.output();
            } else if(s == "3")
            {
                VolumeBalok volumeBalok = new VolumeBalok();
                volumeBalok.input();
                volumeBalok.process();
                volumeBalok.output();
            } else
            {
                break;
            }

            Console.ReadLine();
            Console.Clear();
        }
    }

    public static string input()
    {
        Console.Write("Masukan Input: ");
        return Console.ReadLine();
    }
}