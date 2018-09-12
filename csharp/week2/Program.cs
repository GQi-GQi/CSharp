using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    class Program      //方法
    {
        //方法的声明
        public bool IsPositive(int value)
        {
            if (value < 0)
                return false;
            return true;
        }
    }
    class MainEntryOoint
    {
        static void Main()
        {
            Console.WriteLine("Pi is " + MathTest.GetPi());
        }
    }
    class MathTest
    {
        public int value;
        public int GetSquare()
        {
            return value * value;
        }

        public static int GetSquareOf(int x)
        {
            return x * x;
        }

        public static double GetPi()
        {
            return 3.1415926;
        }
    }
}
