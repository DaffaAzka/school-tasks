internal class Program
{
    private static void Main(string[] args)
    {
        /*
            int i = 1;
            while(i > 7)
            {
                Console.WriteLine(i);
                i++ ;
            }
        */

        task1();
        Console.WriteLine("==============");
        task2();
        Console.WriteLine("==============");
        task3();
    }

    private static void task1()
    {
        Console.WriteLine("tets");
        int i = 1;
        while (i <= 5)
        {
            Console.WriteLine(i);
            i++;
        }
    }

    private static void task2()
    {
        int i = 2;
        while (i <= 10)
        {
            Console.WriteLine(i);
            i += 2;
        }
    } 

    private static void task3()
    {
        int i = 19;
        while (i > 10)
        {
            Console.WriteLine(i);
            i -= 2/;
        }
    }
}