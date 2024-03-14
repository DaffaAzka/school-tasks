internal class Program
{
    private static void Main(string[] args)
    {
        int memberValue = int.Parse(Input("Masukan Jumlah Peserta"));
        string[] number = new string[memberValue];
        string[] name = new string[memberValue];

        string[] jurusan = new string[memberValue];
        string[] grade = new string[memberValue];

        int[] examValue = new int[memberValue];
        int[] ptsValue = new int[memberValue];
        int[] semesterValue = new int[memberValue];

        int[] totalValue = new int[memberValue];

        for (int i = 0; i < memberValue; i++)
        {
            Console.WriteLine("==============================================================");
            number[i] = Input($"Masukan nomor ujian[{i}]");
            name[i] = Input($"Masukan nama peserta ujian[{i}]");
            examValue[i] = int.Parse(Input($"Masukan nilai ulangan[{i}]"));
            ptsValue[i] = int.Parse(Input($"Masukan nilai ujian[{i}]"));
            semesterValue[i] = int.Parse(Input($"Masukan nilai semester[{i}]"));

            int total = (examValue[i] + semesterValue[i] + ptsValue[i]) / 3;
            Console.WriteLine($"Total nilai rapot adalah {total}");
        }

        for (int i = 0; i < memberValue; i++)
        {
            string temp = number[i].Substring(2, 1);

            switch(temp)
            {
                case "M":
                    temp = "Mesin";
                    break;

                case "T":
                    temp = "Teknik Sipil";
                    break;

                case "L":
                    temp = "Listrik";
                    break;

                case "R":
                    temp = "RPL";
                    break;
            }

            jurusan[i] = temp;
        }

        for (int i = 0; i < memberValue; i++)
        {
            string temp = number[i].Substring(3, 2);

            switch (temp)
            {
                case "01":
                    temp = "X";
                    break;

                case "02":
                    temp = "XI";
                    break;

                case "03":
                    temp = "XII";
                    break;
            }

            grade[i] = temp;
        }

        for (int i = 0; i < memberValue; i++)
        {
            totalValue[i] = (examValue[i] + semesterValue[i] + ptsValue[i]) / 3;
        }

        Console.WriteLine("==============================================================");
        Console.WriteLine("No       Nama       Jurusan       Kelas       Nilai");

        for (int i = 0; i < memberValue; i++)
        {
            Console.WriteLine($"{i}       {name[i]}        {jurusan[i]}            {grade[i]}        {totalValue[i]}");
        }
        Console.WriteLine("==============================================================");

        int max = getBigValue(totalValue);
        int min = getSmallValue(totalValue, totalValue[max]);

        Console.WriteLine($"Nilai terbesar didapatkan oleh {name[max]} jurusan {jurusan[max]} dengan nilai {totalValue[max]}");
        Console.WriteLine($"Nilai terkecil didapatkan oleh {name[min]} jurusan {jurusan[min]} dengan nilai {totalValue[min]}");


    }

    private static int getBigValue(int[] arr)
    {
        int x = 0;
        for (int i = 0; i < arr.Length; i++)
        {
            if (x < arr[i])
            {
                x = arr[i];
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (x == arr[i])
            {
                x = i;
            }
        }

        return x;
    }

    private static int getSmallValue(int[] arr, int max)
    {
        int x = max;
        for (int i = 0; i < arr.Length; i++)
        {
            if (arr[i] < x)
            {
                x = arr[i];
            }
        }

        for (int i = 0; i < arr.Length; i++)
        {
            if (x == arr[i])
            {
                x = i;
            }
        }

        return x;
    }



    private static string Input(string s)
    {
        Console.Write(s + ": ");
        var temp = Console.ReadLine();
        return temp;
    }
}