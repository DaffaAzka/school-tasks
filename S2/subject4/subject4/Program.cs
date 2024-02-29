using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject4
{
    public class Program
    {
        public static void Main(string[] args)
        {
            int v1 = 50;
            int v2 = 20;
            int v3 = 75;

            if ((v1 > v2) && (v1 < v3))
            {
                v1 += 10;
                v2 += v1;
            } else
            {
                v1 = v2;
                v2 = v1;
            }

            Console.WriteLine(v1);
            Console.WriteLine(v2);
        }
    }
}
