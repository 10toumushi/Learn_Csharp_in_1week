using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciseEx502
{
    class Program
    {
        static void Main(string[] args)
        {
            IMul m = new Mul1();
            Console.Write("a=");
            int a = int.Parse(Console.ReadLine());
            Console.Write("b=");
            int b = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", a, b, m.Calc(a, b));
            Console.WriteLine();

            IMul m2 = new Mul2();
            Console.Write("c=");
            int c = int.Parse(Console.ReadLine());
            Console.Write("d=");
            int d = int.Parse(Console.ReadLine());
            Console.WriteLine("{0} * {1} = {2}", c, d, m2.Calc(c, d));
        }
    }
}
