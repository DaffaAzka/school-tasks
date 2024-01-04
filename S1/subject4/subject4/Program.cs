using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subject4
{
    internal class Program
    {
        public static void Main()
        {
            Console.Write("Enter value item: ");
            int value = int.Parse(Console.ReadLine());

            if (value >= 10)
            {
                Console.WriteLine("Anda mendapatkan diskon 10%");
            }
            Console.WriteLine("Selesai");
        }

    }
}
