using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            double S, V;
            GetParams(a, out S, out V);
        }
        static void GetParams(int a, out double S, out double V)
        {
            S = 6 * Math.Pow(a, 2);
            V = Math.Pow(a, 3);
            Console.WriteLine("{0} {1}", S, V); ;
            Console.ReadKey();

        }
    }
}
