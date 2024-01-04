internal class Program
{
    private static void Main(string[] args)
    {
        have3();
    }

    private static void have2()
    {
        Console.Write("I1 : ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("I2 : ");
        int n2 = int.Parse(Console.ReadLine());

        if ((n1 > n2) && (n2 < n1))
        {
            Console.WriteLine($"{n1} has bigger number");
            Console.WriteLine($"{n2} has smaller number");
        } else
        {

            Console.WriteLine($"{n2} has bigger number");
            Console.WriteLine($"{n1} has smaller number");
        }
    }

    private static void have3()
    {
        Console.Write("I1 : ");
        int n1 = int.Parse(Console.ReadLine());

        Console.Write("I2 : ");
        int n2 = int.Parse(Console.ReadLine());


        Console.Write("I3 : ");
        int n3 = int.Parse(Console.ReadLine());

        if ((n1 > n2) && (n2 < n1) && (n3 < n1))
        {
            Console.WriteLine($"{n1} has bigger number");
            if ((n2 > n3))
            {
                Console.WriteLine($"{n2} has middle number");
                Console.WriteLine($"{n3} has smaller number");
            } else
            {
                Console.WriteLine($"{n3} has middle number");
                Console.WriteLine($"{n2} has smaller number");
            }
        } else if ((n2 > n1) && (n1 < n2) && (n3 < n2))
        {
            Console.WriteLine($"{n2} has bigger number");
            if ((n1 > n3))
            {
                Console.WriteLine($"{n1} has middle number");
                Console.WriteLine($"{n3} has smaller number");
            } else
            {

                Console.WriteLine($"{n3} has middle number");
                Console.WriteLine($"{n1} has smaller number");
            }
        } else
        {
            Console.WriteLine($"{n3} has bigger number");
            if ((n1 > n2))
            {
                Console.WriteLine($"{n1} has middle number");
                Console.WriteLine($"{n2} has smaller number");
            }
            else
            {

                Console.WriteLine($"{n2} has middle number");
                Console.WriteLine($"{n1} has smaller number");
            }
        }
    }
}