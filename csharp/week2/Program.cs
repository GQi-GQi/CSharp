using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    class ParmeterTest      //给方法传递参数（区别值类型，引用类型）
    {
        static void SomeFunction(out int i)     //out关键字
        {
            i = 100;
        }
        public static int Main()
        {
            int i;
            SomeFunction(out i);
            Console.WriteLine("i = " + i);
            Console.ReadLine();
            return 0;
        }
    }
    
}
