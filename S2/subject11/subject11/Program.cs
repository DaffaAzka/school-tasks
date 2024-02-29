internal class Program
{
    private static void Main(string[] args)
    {
        Input("Masukan nama");
        var no = Input("Masukan Nomor Ujian");

        var gender = no.Substring(0, 1);
        var jurusan = no.Substring(1, 2);
        var location = no.Substring(3, 1);
        var floor = no.Substring(4, 1);
        var table = no.Substring(5, 3);

        if (gender.ToLower().Equals("l"))
        {
            gender = "Laki laki";
        } else
        {
            gender = "Perempuan";
        }


        switch (jurusan)
        {
            case "01":
                jurusan = "Mesin";
                break;

            case "02":
                jurusan = "Listrik";
                break;

            case "03":
                jurusan = "Teknik Sipil";
                break;

            case "04":
                jurusan = "Geomatika";
                break;

            case "05":
                jurusan = "RPL";
                break;
        }

        Console.WriteLine($"Jenis Kelamin: {gender}");
        Console.WriteLine($"Jurusan: {jurusan}");
        Console.WriteLine($"Lokasi gedung ujian: {location}");
        Console.WriteLine($"Lantai gedung: {floor}");
        Console.WriteLine($"Nomor meja: {table}");

    }

    private static string Input(string s)
    {
        Console.Write(s + ": ");
        var temp = Console.ReadLine();
        return temp;
    }
}