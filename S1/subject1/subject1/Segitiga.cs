using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject1
{
    internal class Segitiga
    {
        public void Calculate() {
            int alas, tinggi;
            double luas;

            alas = 5;
            tinggi = 8;
            luas = 0.5 * alas * tinggi;

            Console.WriteLine("Luas: " + luas);
        }
    }
}
