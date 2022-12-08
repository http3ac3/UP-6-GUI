using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void rec(double a0, double d, int n, out double sum, out double an)
        {
            an = a0;
            sum = 0;
            sum += d * n;
            if (n == 0) return;
            rec(a0 + d, d, n - 1, out sum, out an);
        }
        static void Main(string[] args)
        {
            Console.Write("a0 -> ");
            double a0 = double.Parse(Console.ReadLine());

            Console.Write("d -> ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("n -> ");
            int n = int.Parse(Console.ReadLine());

            double sum, an;

            rec(a0, d, n, out sum, out an);
            Console.WriteLine(sum + " " + an);
        }
    }
}
