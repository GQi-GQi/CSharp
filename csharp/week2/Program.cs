using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program
{
    class Client    //然后在菜单Project->***** Properties->Application选项卡中的Startup object：中，选择你希望那个作为程序入口的Main()函数所在的类的类名，运行即可！
    {
        public static int Main()
        {
            MathExample.Main();
            return 0;
        }
        class MathExample
        {
            static int Add(int x,int y)
            {
                return x + y;
            }
            public static int Main()
            {
                int i = Add(5, 10);
                Console.WriteLine(i);
                return 0;
            }
        }
    }
}
