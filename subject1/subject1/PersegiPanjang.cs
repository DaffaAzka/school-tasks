using System;

namespace subject1
{ 
    internal class PersegiPanjang
    {
        public static void Calculate()
        {
            int panjang, lebar;
            double luas;

            panjang = 100;
            lebar = 80;

            luas = panjang * lebar;
            Console.WriteLine("Luas: " + luas);
        }
    }
}
