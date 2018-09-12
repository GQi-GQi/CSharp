using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    class Program      //类（储存在堆上的引用类型）
    {
        public const string DayOfSendingBill = "Monday";
        public int CustomerID;
        public string FirstName;
        public string LastName;
    }
    struct PhoneCustomerStruct      //结构（储存在栈上的值类型，较小的数据类型使用结构可以提高性能）
    {
        public const string DayOfSendingBill = "Monday";
        public int CustomerID;
        public string FirstName;
        public string LastName;
    }
}
