internal class Program
{
    private static void Main(string[] args)
    {
        while (true)
        {
            Console.Clear();
            Console.WriteLine("==========================");
            Console.WriteLine("1. Menghitung Luas Segitiga");
            Console.WriteLine("2. Menghitung Luas Balok");
            Console.WriteLine("3. Menghitung Luas Lingkaran");
            Console.WriteLine("4. Menghitung Volume Balok");
            Console.WriteLine("5. Keluar");
            Console.WriteLine("==========================");
            int decide = Input("Masukan input anda");
            Console.WriteLine("==========================");

            if (decide == 1)
            {
                int alas = Input("Masukan alas");
                int tinggi = Input("Masukan tinggi");
                Console.WriteLine($"Luas Segitiga : {CalculateTrinangle(alas, tinggi)}²");
            }
            else if (decide == 2)
            {
                int panjang = Input("Masukan alas");
                int lebar = Input("Masukan tinggi");
                Console.WriteLine($"Luas Persegi Panjang : {CalculateLongRectangle(panjang, lebar)}²");
            }
            else if (decide == 3)
            {
                int ruas = Input("Masukan jaring");
                Console.WriteLine($"Luas Lingkaran : {CalculateCircle(ruas)}²");
            }
            else if (decide == 4)
            {
                int panjang = Input("Masukan panjang");
                int lebar = Input("Masukan lebar");
                int tinggi = Input("Masukan tinggi");
                Console.WriteLine($"Volume Balok : {CalculateVolume(lebar, panjang, tinggi)}");
            }
            else if (decide == 5)
            {
                break;
            }

            Console.ReadLine();
        }
    }

    private static double CalculateTrinangle(int a, int b)
    {
        double result = 0.5 * a * b;
        return result;
    }

    private static int CalculateLongRectangle(int a, int b)
    {
        int result = a * b;
        return result;
    }

    private static double CalculateCircle(int a)
    {
        double result = 3.14 * (a * a);
        return result;
    }

    private static int CalculateVolume(int a, int b, int c)
    {
        int result = a * b * c;
        return result;
    }

    private static int Input(string a)
    {
        while(true)
        {
            try
            {
                Console.Write($"{a} : ");
                int temp = int.Parse(Console.ReadLine());
                return temp;
            } catch
            {
                Console.WriteLine("Input yang anda masukan bukanlah sebuah angka!");
            }
        }
    }
}