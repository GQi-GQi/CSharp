using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace program
{
    class ArgsExample           //使用命令就可以编译这段代码。在运行编译好的可执行文件时，可以在程序名的后面加上参数。eg：ArgeExample /a/b/c
    {
        public static int Main(string[] args)
        {
            for (int i = 0; i < args.Length; i++)
            {
                Console.WriteLine(args[i]);
            }
            return 0;
        }
    }
}
