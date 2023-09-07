using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject2
{
    internal class Lingkaran
    {
        public static void Calculate()
        {
            int ruas = InputUtil.InputInteger("Ruas");
            double luas = 3.14 * ruas * ruas;
            Console.WriteLine("Luas: " + luas);

        }
    }
}
