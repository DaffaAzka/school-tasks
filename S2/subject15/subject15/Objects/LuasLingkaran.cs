using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject15.Objects
{
    public class LuasLingkaran
    {
        int ruas;
        double luas;

        public void input()
        {
            Console.Write("Input ruas: ");
            ruas = int.Parse(Console.ReadLine());
        }

        public void process()
        {
            luas = 3.14 * (ruas * ruas);
        }

        public void output()
        {
            Console.WriteLine($"The result is: {luas}");
        }
    }
}
