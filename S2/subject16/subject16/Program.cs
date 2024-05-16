internal class Program
{
    private static void Main(string[] args)
    {
        Segitiga segitiga = new Segitiga();
        segitiga.input();
        segitiga.process();
        segitiga.result();
    }
}

class Segitiga
{
    int alas, tinggi;
    double luas;

    public void input()
    {
        Console.Write("Input alas: ");
        alas = int.Parse(Console.ReadLine());

        Console.Write("Input alas: ");
        tinggi = int.Parse(Console.ReadLine());
    }

    public void process()
    {
        luas = 0.5 * alas * tinggi;
    }

    public void result()
    {
        Console.WriteLine($"The result is: {luas}");
    }
}