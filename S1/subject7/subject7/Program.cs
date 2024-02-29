internal class Program
{
    private static void Main(string[] args)
    {
        // Deklarasi Variabele
        String? nama, keterangan, grade;
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
        keterangan = (hasil >= 60) ? "Lulus" : "Silahlan mengambil remedial";

        if (hasil >= 80)
        {
            grade = "A";
        }
        else if (hasil >= 70)
        {
            grade = "B";
        }
        else if (hasil >= 60)
        {
            grade = "C";
        }
        else if (hasil >= 50)
        {
            grade = "D";
        }
        else
        {
            grade = "E";
        }

        Console.WriteLine("Nilai Rapot : " + hasil);
        Console.WriteLine("Keterangan  : " + keterangan);
        Console.WriteLine("Grade       : " + grade);

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