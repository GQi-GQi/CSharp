﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace week1
{
    #region 2.2第一个C#程序
    //public class Program1
    //{
    //    static void Main(string[] args)
    //    {
    //        Console.WriteLine("Hello from Wrox.");
    //        Console.ReadLine();
    //        return;
    //    }
    //}
    #endregion

    #region 2.3变量
    //public class Program2
    //{
    //    static void Main(string[] args)
    //    {
    //        var name = "Bugs Bunny";
    //        var age = 25;
    //        var isRabbit = true;

    //        Type nameType = name.GetType();
    //        Type ageType = age.GetType();
    //        Type isRabbitType = isRabbit.GetType();

    //        Console.WriteLine("name is type " + nameType.ToString());
    //        Console.WriteLine("age is type " + ageType.ToString());
    //        Console.WriteLine("isRabbit is type " + isRabbitType.ToString());
    //        Console.ReadLine();s
    //    }
    //}
    #endregion

    #region 2.3.2变量作用域
    public class  Program3
    {
        public static void Main(string[]  args)
        {
            for (int i = 0; i < 10; i++)     //i只作用于这个循环
            {
                Console.WriteLine(i);
            }
            for (int i = 9; i >= 0; i--)     //i只作用于这个循环
            {
                Console.WriteLine(i);
            }
            return;
        }
    }
    #endregion
}