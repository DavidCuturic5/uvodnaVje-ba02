using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace uvodnaVježba02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            double d, c, x;

            a = 10;
            b = 7;
            c = 12.5;
            d = 16.7;

            x = (a + b + c + d) / 4;

            string ispis = "Prosjecna vrijednost od brojeva " + a + ", " + b + ", " + c + " i " + d+""+ " je " + x;
            Console.WriteLine( ispis );
            Console.ReadKey ();
        }
    }
}
