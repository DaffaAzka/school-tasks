using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject1
{
    public static class Utilities
    {
        public static int input(String s)
        {
            Console.Write($"{s}: ");
            return getOutput();
        }

        private static int getOutput() {
            int n = 0;
            while (true)
            {
                try
                {
                    n = int.Parse(Console.ReadLine());
                    break;
                } catch ( Exception e )
                {
                    Console.Write($"Error Exception (Silahkan Input Ulang) : ");
                }
            }
            return n;
        }

    }
}
