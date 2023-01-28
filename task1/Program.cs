using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArithProgression arith = new ArithProgression(1 , 2);
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            arith.Reset();
            arith.Step = 5;
            Console.WriteLine(arith.GetNext());
            Console.WriteLine(arith.GetNext());
            GeomProgression geom = new GeomProgression(1, 2);
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());
            geom.Reset();
            geom.Step = 5;
            Console.WriteLine(geom.GetNext());
            Console.WriteLine(geom.GetNext());

            Console.ReadKey();
        }
    }
}
