internal class Program
{
    private static void Main(string[] args)
    {
        char kar;
        Console.Write("Masukan buruk: ");
        kar = Console.ReadLine()[0];

        switch (kar)
        {
            case 'a':
                Console.WriteLine("Huruf Vocal");
                break;

            case 'i':
                Console.WriteLine("Huruf Vocal");
                break;

            case 'u':
                Console.WriteLine("Huruf Vocal");
                break;

            case 'e':
                Console.WriteLine("Huruf Vocal");
                break;

            case 'o':
                Console.WriteLine("Huruf Vocal");
                break;

            default : 
                Console.WriteLine("Huruf Konsonan");
                break;
        }
    }
}