internal class Program
{
    private static void Main(string[] args)
    {
        string name = Input("masukkan nama");
        string gender = Input("masukkan jenis kelamin");
        int age = int.Parse(Input("masukkan umur"));
        int discount = 0;

        if (gender == "L" && age >= 50)
        {
            discount = 100000;
        } else if (gender == "W" && age <= 15)
        {
            discount = 50000;
        }

        Console.WriteLine($"Discount: {discount}");
    }

    private static string Input(string s)
    {
        Console.Write($"{s}: ");
        string v = Console.ReadLine();
        return v;
    }
}