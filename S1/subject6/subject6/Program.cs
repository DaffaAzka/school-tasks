internal class Program
{
    private static void Main(string[] args)
    {
        // Deklarasi Variabele
        int nilai;

        nilai = InputInteger("nilai");
        if (nilai >= 80)
        {
            Console.WriteLine("Keterangan: A");
        }
        else if (nilai >= 70)
        {
            Console.WriteLine("Keterangan: B");
        }
        else if (nilai >= 60)
        {
            Console.WriteLine("Keterangan: C");
        }
        else
        {
            Console.WriteLine("Keterangan: D");
        }

    }


    // Function Validasi Data Yang Di Input Adalah Int Bukan String
    public static int InputInteger(String s)
    {
        while (true)
        {
            try
            {
                Console.Write("Masukan nilai " + s + " : ");
                int e = int.Parse(Console.ReadLine());
                return e;
            }
            catch
            {
                Console.WriteLine("Input " + s + " yang anda masukan bukan angka, silahkan masukan ulang!");
            }
        }
    }
}