internal class Program
{
    private static void Main(string[] args)
    {
        Input("Masukan Nama Siswa", "s");
        int tugas = Input("Masukan Nilai Tugas", "i");
        int uts = Input("Masukan Nilai UTS", "i");
        int semester = Input("Masukan Nilai Semester", "i");

        var cal = Calculate(tugas, uts, semester);
        Output(cal);
    }

    private static int Input(string a, string type)
    {
        while (true)
        {
            Console.Write($"{a} : ");
            string temp = Console.ReadLine();
            if (type == "s")
            {
                return 0;
            } else
            {
                try
                {
                    int res = int.Parse(temp);
                    return res;
                }
                catch
                {
                    Console.WriteLine("Input yang anda masukan bukanlah sebuah angka!");
                }
            }
        }
    }

    
    private static double Calculate(int a, int b, int c)
    {
        return (a + b + c) / 3;
    }

    private static void Output(double a)
    {
        Console.WriteLine($"Nilai Rapor: {a}");
        String temp = "";
        if (a >= 70)
        {
            temp = "Baik";
        }
        else if (a >= 60)
        {
            temp = "Cukup";
        } else
        {
            temp = "Buruk";
        }
        Console.WriteLine($"Keterangan: {temp}");
    }
}