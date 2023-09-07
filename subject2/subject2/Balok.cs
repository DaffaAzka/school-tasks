using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject2
{
    internal class Balok
    {
        public static void Calculate()
        {

            int panjang = InputUtil.InputInteger("Panjang");
            int lebar = InputUtil.InputInteger("Lebar");
            int tinggi = InputUtil.InputInteger("Tinggi");

            double volume = panjang * lebar * tinggi;
            Console.WriteLine("Volume: " + volume);

        }
    }
}
