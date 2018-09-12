using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program               //3.3.2.3 构造函数（静态构造函数）
{
    public class UserPreferences     //创建一个类
    {
        public static readonly ConsoleColor BackColor;
        static UserPreferences()
        {
            DateTime now = DateTime.Now;
            if (now.DayOfWeek == DayOfWeek.Saturday || now.DayOfWeek == DayOfWeek.Sunday)
                BackColor = ConsoleColor.Green;
            else
                BackColor = ConsoleColor.Red;
        }
        private UserPreferences()
        {

        }

        static void Main()
        {
            Console.ReadLine();
            return;
        }
    }
    
}
