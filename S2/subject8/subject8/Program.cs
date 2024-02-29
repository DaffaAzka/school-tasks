internal class Program
{
    private static void Main(string[] args)
    {
        string[] names = new string[6];
        int[] values = new int[6];
        GFG comparator = new GFG();


        for (int i = 0; i < names.Length; i++)
        {
            names[i] = Input($"Enter student-{i} name");
            values[i] = int.Parse(Input($"Enter student-{i} value"));
            Console.WriteLine("==================");
        }

        Console.WriteLine("Daftar Nilai Matematika");
        Console.WriteLine("No   Nama        Nilai    Keterangan     Grade");
        Console.WriteLine("================================================");
        

        for (int i = 0; i < values.Length; i++)
        {
            // Keterangan
            string ket = "Baik";
            if (values[i] <= 50)
            {
                ket = "Buruk";
            } else if (values[i] <= 70)
            {
                ket = "Cukup";
            }

            // Grade
            string grade = "A";
            if (values[i] <= 50)
            {
                grade = "C";
            }
            else if (values[i] <= 70)
            {
                grade = "B";
            }

            Console.WriteLine($"{i}     {names[i]}          {values[i]}         {ket}       {grade}");
        }

        var list = values.ToList();
        list.Sort(comparator);

        var highName = getHighScoreName(list.Last(), names, values);

        Console.WriteLine($"Nilai Tertinggi di dapatkan oleh {highName} dengan jumlah: {list.Last()}");
    }

    class GFG : IComparer<int>
    {
        public int Compare(int x, int y)
        {
            if (x == 0 || y == 0)
            {
                return 0;
            }

            // CompareTo() method 
            return x.CompareTo(y);

        }
    }

    private static string getHighScoreName(int n, string[] names, int[] values)
    {
        string s = "";
        for (int i = 0; i < names.Length; i++)
        {
            if (values[i] == n)
            {
                s = names[i];
            }
        }
        return s;
    }

    private static string Input(string s)
    {
        Console.Write($"{s}: ");
        return Console.ReadLine();
    }
}