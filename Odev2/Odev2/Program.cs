using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            
            sw.Start();

            Console.ReadKey();
            sw.Stop();
            Console.WriteLine("Sure: " + sw.Elapsed);

            Console.ReadKey();
        }
    }
}
