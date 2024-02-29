internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = new string[5];
        string[] numbers = new string[5];

        for (int i = 0; i < names.Length; i++)
        { 
            names[i] = Input($"Masukan nama[{i}]");
            numbers[i] = Input($"Masukan nomor ujian[{i}]");
        }

        string[] tahun = new string[5];
        string[] gender = new string[5];
        string[] jurusan = new string[5];

        for (int i = 0; i < numbers.Length; i++)
        {
            gender[i] = numbers[i].Substring(0, 1) == "L" ? "Laki Laki" : "Perempuan";
            tahun[i] = $"19{numbers[i].Substring(4, 2)}";
            jurusan[i] = numbers[i].Substring(2, 2);

            switch(jurusan[i])
            {
                case "01":
                    jurusan[i] = "Mesin";
                    break;

                case "02":
                    jurusan[i] = "Listrik";
                    break;

                case "03":
                    jurusan[i] = "RPL";
                    break;

                case "04":
                    jurusan[i] = "Teknik Sipil";
                    break;
            }
        }

        Console.WriteLine("Daftar Peserta Ujian");
        Console.WriteLine("No   Nama    Tahun Masuk     Jenis Kelamin   Jurusan");
        Console.WriteLine("====================================================================");

        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine($"{i}   {names[i]}        {tahun[i]}          {gender[i]}         {jurusan[i]}");
        }

        Console.WriteLine("====================================================================");
 

    }

    private static string Input(string s)
    {
        Console.Write(s + ": ");
        var temp = Console.ReadLine();
        return temp;
    }
}