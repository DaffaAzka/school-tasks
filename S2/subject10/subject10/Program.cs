internal class Program
{
    private static void Main(string[] args)
    {

        var nim = Input("Masukan NIM");

        var masuk = nim.Substring(0, 2);
        var jurusan = nim.Substring(2, 2);
        var jenjang = nim.Substring(4, 1);

        // Console.WriteLine($"{masuk} | {jurusan} | {jenjang}");

        switch(jurusan)
        {
            case "11":
                jurusan = "Teknik Informatika";
                break;

            case "22":
                jurusan = "Menejemen Informatika";
                break;

            case "33":
                jurusan = "Teknik Komputer";
                break;

            case "44":
                jurusan = "Komputer Akuntansi";
                break;

            default:
                jurusan = "Data yang anda masukan tidak valid";
                break;
        }

        switch(jenjang)
        {
            case "5":
                jenjang = "S1 (Sarjana 1)";
                break;

            case "D3":
                jenjang = "Diploma 3";
                break;

            default:
                jurusan = "Data yang anda masukan tidak valid";
                break;
        }

        Console.WriteLine($"Tahun masuk 19{masuk}");
        Console.WriteLine($"Jurusan {jurusan}");
        Console.WriteLine($"Jenjang {jenjang}");


    }

    private static string Input(string s)
    {
        Console.Write(s + ": ");
        var temp = Console.ReadLine();
        return temp;
    }
}