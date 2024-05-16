using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject15.Objects
{
    public class LuasPersegiPanjang
    {
        int panjang, lebar;
        double luas;

        public void input()
        {
            Console.Write("Input panjang: ");
            panjang = int.Parse(Console.ReadLine());

            Console.Write("Input lebar: ");
            lebar = int.Parse(Console.ReadLine());

        }

        public void process()
        {
            luas = (panjang * lebar);
        }

        public void output()
        {
            Console.WriteLine($"The result is: {luas}");
        }
    }
}
