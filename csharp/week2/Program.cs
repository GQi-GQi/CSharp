using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week2
{
    class Vector
    {
        public int Value;
    }
    class Program
    {
        #region 2.3.3字段和局部变量的作用域冲突
        //static int j = 20;
        //static void Main(string[] args)
        //{
        //    int j = 30;
        //    Console.WriteLine(j);
        //    Console.WriteLine(Week2.j);
        //    Console.ReadLine();
        //    return;
        //}
        #endregion

        #region 2.4.1值类型和引用
        //static void Main()
        //{
        //    Vector x, y;            //值类型
        //    x = new Vector();       //只有一个对象（只有一个Value值）
        //    x.Value = 30;
        //    y = x;
        //    Console.WriteLine(y.Value);
        //    y.Value = 50;
        //    Console.WriteLine(x.Value);
        //    Console.ReadLine();
        //    return;
        //}
        #endregion

        #region 2.4.4string类型
        //static void Main()
        //{
        //    string s1 = "a string";         //创建一个string对象，分配到堆上面
        //    string s2 = s1;                 //s2也是指向s1的对象上
        //    Console.WriteLine("s1 is " + s1);
        //    Console.WriteLine("s2 is " + s2);
        //    s1 = "another string";          //堆上会为新值分配一个新的对象
        //    Console.WriteLine("s1 is now " + s1);
        //    Console.WriteLine("s2 is now " + s2);
        //    Console.ReadLine();
        //    return;
        //}
        #endregion
    }
}
