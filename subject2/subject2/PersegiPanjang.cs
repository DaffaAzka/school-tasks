using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject2
{
    internal class PersegiPanjang
    {
        public static void Calculate()
        {
            int panjang, lebar;
            double luas;

            panjang = InputUtil.InputInteger("Panjang");
            lebar = InputUtil.InputInteger("Lebar");

            luas = 0.5 * panjang * lebar;
            Console.WriteLine("Luas: " + luas);
        }

        
    }
}
