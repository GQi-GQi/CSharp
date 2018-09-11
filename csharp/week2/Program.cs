using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program
{
    class MathAdd       //控制台
    {
        static void Main()
        {
            int i = 10;
            int j = 20;
            Console.WriteLine("{0} plus {1} equals {2}", i, j, i + j);

            Console.WriteLine(" {0,4}\n+{1,4}\n--------\n {2,4}", i, j, i + j);
            decimal k = 940.23m;
            decimal l = 73.7m;
            Console.WriteLine(" {0,9:C2}\n+{1,9:C2}\n-----------\n {2,9:C2}", k, l, k + l);

            double d = 11.004;
            Console.WriteLine("{0:#.00}", d);

            Console.ReadLine();
            return;
        }
    }
}
