internal class Program
{
    private static void Main(string[] args)
    {
        String code = "";
        int timeIn, timeOut, duration;
        int bill = 0;
        int feeEarly = 2000;
        int fee = 500;

        Console.Write("Enter your bycyle code");
        code = Console.ReadLine();

        timeIn = Input("Enter the timeIn");
        timeOut = Input("Enter the timeOut");

        if (timeIn >= timeOut)
        {
            int temp = 0;
            for (int i = 1; i < 10; i++)
            {
                timeIn++;
                if (timeIn == 12)
                {
                    temp = i;
                    break;
                }
            }
            duration = timeOut + temp;
        } else
        {
            duration = timeOut - timeIn;
        }


        for (int i = 1; i <= duration; i++)
        {
            if (i <= 2)
            {
                bill += feeEarly;
            } else
            {
                bill += fee;
                fee += 500;
            }
        }

        Console.WriteLine($"Parkir duration {duration} hours");
        Console.WriteLine($"Bill : Rp.{bill}");

    }










    public static int Input(String s)
    {
        Console.Write($"{s}: ");
        return GetOutput();
    }

    private static int GetOutput()
    {
        int n = 0;
        while (true)
        {
            try
            {
                n = int.Parse(Console.ReadLine());
                break;
            }
            catch (Exception e)
            {
                Console.Write($"Error Exception (Silahkan Input Ulang) : ");
            }
        }
        return n;
    }
}