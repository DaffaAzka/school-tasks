using System.Runtime.Intrinsics.Arm;

internal class Program
{
    private static void Main(string[] args)
    {
        task5();
    }

    private static void  task1()
    {
        int i = 40;
        do { Console.WriteLine(i); i--; } while(i >= 30);
    }

    private static void task2()
    {
        int i = 1;
        do { Console.WriteLine(i); i+=2; } while (i <= 10);
    }

    private static void task3()
    {
        int i = 40;
        do { Console.WriteLine(i); i-=2; } while (i >= 20);
    }

    private static void task4()
    {
        int i = 10;
        int j = 70;
        do { Console.WriteLine(i + " " + j); i+=10; j -= 10; } while (i <= 50);
    }

    private static void task5()
    {
        int i = 1;
        int j = 0;
        do { 
            Console.WriteLine(i);
            i += i;
        } while (i <= 22);
    }
}