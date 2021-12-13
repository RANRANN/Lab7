using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double s1 = CalcS(3, 4, 5);
            Console.Write("{0} ", s1);
            double s2 = CalcS(5, 6, 7);
            Console.WriteLine("{0:f2}", s2);
            Console.WriteLine("{0:f2}", Math.Max(s1, s2));
            Console.ReadKey();
        }
        static double CalcS(int x, int y, int z)
        {
            double p = (x + y + z) / 2;
            double S = Math.Sqrt(p * (p - x) * (p - y) * (p - z));
            return S;
        }
    }
}
