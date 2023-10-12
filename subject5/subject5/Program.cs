internal class Program
{
    private static void Main(string[] args)
    {
        // Deklarasi Variabele
        String nama;
        int nilaiTugas, nilaiUTS, nilaiSemester;
        double hasil;

        // Input Data nama
        Console.Write("Masukan Nama Siswa : ");
        nama = Console.ReadLine();

        // Input Data nilaiTugas
        nilaiTugas = InputInteger("tugas");


        // Input Data nilaiUTS
        nilaiUTS = InputInteger("UTS");

        // Input Data nilaiSemester
        nilaiSemester = InputInteger("Semester");

        hasil = (nilaiTugas + nilaiUTS + nilaiSemester) / 3;
        if (hasil >= 70.0)
        {
            Console.WriteLine("Keterangan: Lulus");
            Console.WriteLine("Pesan: Selamat " + nama + ", Anda Lulus Dengan nilai " + hasil);
        } else
        {
            Console.WriteLine("Keterangan: Gagal");
            Console.WriteLine("Pesan: Mohon Maaf " + nama + ", Anda Gagal Dengan nilai " + hasil);
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