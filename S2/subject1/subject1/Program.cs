using subject1;

internal class Program
{
    private static void Main(string[] args)
    {
        var list = new List<int>();
        GFG comparator = new GFG();

        Console.WriteLine($"Enter your number and if you done just input '99'");

        while (true)
        {
            int n = Utilities.input("Pick your number");
            if (n == 99)
            {
                break;
            } else { list.Add(n); }
        }

        list.Sort(comparator);

        Console.WriteLine("==============================");
        Console.WriteLine($"{list.Last()} : Adalah bilangan terbesar");
        Console.WriteLine($"{list.First()} : Adalah bilangan terkecil");
    }

    
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