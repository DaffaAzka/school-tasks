using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject2
{
    internal class Segitiga
    {
        public static void Calculate()
        {
            int alas, lebar;
            double luas;

            alas = InputUtil.InputInteger("Alas");
            lebar = InputUtil.InputInteger("Lebar");

            luas = 0.5 * alas * lebar;
            Console.WriteLine("Luas: " + luas);
        }
    }
}
