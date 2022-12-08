using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Rec(double a0, double d, int n, double s, out double an, out double sum)
        {
            an = a0;
            s += a0;
            sum = s;
            if (n == 1) return;
            Rec(a0 + d, d, n - 1, s, out an, out sum);
        }
        static void Main(string[] args)
        {
            Console.Write("a0 = ");
            double a0 = double.Parse(Console.ReadLine());

            Console.Write("d = ");
            double d = double.Parse(Console.ReadLine());

            Console.Write("n = ");
            int n = int.Parse(Console.ReadLine());

            double an, sum;
            Rec(a0, d, n, 0, out an, out sum);
            Console.WriteLine($"An = {an}, sum = {sum}");
        }
    }
}
