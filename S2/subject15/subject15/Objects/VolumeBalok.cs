using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace subject15.Objects
{
    public class VolumeBalok
    {

        int panjang, lebar, tinggi;
        double volume;

        public void input()
        {
            Console.Write("Input panjang: ");
            panjang = int.Parse(Console.ReadLine());

            Console.Write("Input lebar: ");
            lebar = int.Parse(Console.ReadLine());


            Console.Write("Input tinggi: ");
            tinggi = int.Parse(Console.ReadLine());
        }

        public void process()
        {
            volume = panjang * lebar * tinggi;
        }

        public void output()
        {
            Console.WriteLine($"The result is: {volume}");
        }
    }

}

