using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject2
{
    internal class InputUtil
    {
        public static int InputInteger(String s)
        {
            while (true)
            {
                try
                {
                    Console.Write("masukan " + s + ": ");
                    int e = int.Parse(Console.ReadLine());
                    return e;
                }
                catch 
                {
                    Console.WriteLine("Input " + s + " yang anda masukan bukan angka, silahkan masukan ulang!");
                }
            }
        }
    }
}
