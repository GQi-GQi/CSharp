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

        #region 2.5.1条件语句if...else...
        //static void Main(string[] args)
        //{
        //    Console.WriteLine("Type in a string");
        //    string input;
        //    input = Console.ReadLine();
        //    if (input == "")
        //    {
        //        Console.WriteLine("You typed in an empty string.");
        //    }
        //    else if (input.Length < 5)
        //    {
        //        Console.WriteLine("The string had less than 5 charcters.");
        //    }
        //    else if (input.Length < 10)
        //    {
        //        Console.WriteLine("The string had at least 5 but less than 10 Characters.");
        //    }
        //    Console.WriteLine("The string was " + input);
        //    Console.ReadLine();
        //    return;
        //}
        #endregion

        #region 2.5.1条件语句switch
        //static void Main(string[] args)
        //{
        //    int integerA;
        //    integerA = Convert.ToInt32(Console.ReadLine());
        //    switch (integerA)
        //    {
        //        case 1:
        //            Console.WriteLine("integerA = 1");
        //            break;
        //        case 2:
        //            Console.WriteLine("integerA = 2");
        //            break;
        //        case 3:
        //            Console.WriteLine("integerA = 3");
        //            break;
        //        default:
        //            Console.WriteLine("integerA is not 1,2, or 3.");
        //            break;
        //    }
        //    return;
        //}
        #endregion

        #region 2.5.2.1 for循环
        //static void Main()
        //{
        //    for (int i = 0; i < 100; i += 10)
        //    {
        //        for (int j = i; j < i + 10; j++) 
        //        {
        //            Console.Write(" " + j);
        //        }
        //        Console.WriteLine();
        //    }
        //    Console.ReadLine();
        //    return;
        //}
        #endregion

        #region 2.5.2.2 while循环
        //static void Main(string[] agrs)
        //{
        //    bool condition = false;
        //    while (!condition)
        //    {
        //        DoSomeWork();       //暂时没有定义DoSomeWork()方法
        //        condition = CheckeCondition();      //暂时没有定义CheckCondition()方法
        //    }
        //}
        #endregion

        #region 2.5.2.3do...while循环
        //static void Main(string[] agrs)
        //{
        //    bool condition = false;
        //    do
        //    {
        //        DoSomeWork();       //暂时没有定义DoSomeWork()方法
        //        condition = CheckeCondition();      //暂时没有定义CheckCondition()方法
        //    }while (condition) ;
        //}
        #endregion

        #region  2.5.2.4 foreach循环
        //static void Main(string[] agrs)
        //{
        //   foreach(int temp in arrayOfInts)     //假定arrayOfInts是一个整形数组，foreach每次把每一个元素的值放在int temp中。
        //    {
        //        Console.WriteLine(temp);
        //    }
        //}
        #endregion

        #region 2.5.3 跳转语句
        //goto直接跳转程序中的用标签指定的另一行（标签是一个标识符，后跟一个冒号）不能跳转循环语句里，不能跳出类的范围，不能跳出try...catch后面的finally块
        //break语句用于退出循环语句的循环，执行后面的语句，不能放在循环的外部。
        //continue语句类似break语句但它只退出循环的当前迭代，开始执行下一次的迭代，而不是退出循环。
        //return语句用于退出类的方法，把控制权返回方法的调用者。如果方法有返回类型，return必须返回这个类型的值；如果方法返回void。应使用没有表达式的return语句。
        #endregion

        #region 2.6 枚举
        //public static int Main()
        //{
        //    WriteGreeting(TimeOfDay.Morning);
        //    return 0;
        //}

        //private static void WriteGreeting(TimeOfDay timeOfDay)
        //{
        //    switch(timeOfDay)
        //    {
        //        case TimeOfDay.Morning:
        //            Console.WriteLine("Good morning!");
        //            break;
        //        case TimeOfDay.Afternoon:
        //            Console.WriteLine("Good afternoon!");
        //            break;
        //        case TimeOfDay.Evening:
        //            Console.WriteLine("Good evening!");
        //            break;
        //        default:
        //            Console.WriteLine("Hello!");
        //            break;
        //    }
        //}

        //public enum TimeOfDay
        //{
        //    Morning = 0,
        //    Afternoon = 1,
        //    Evening = 2
        //}
        #endregion

    }
}
