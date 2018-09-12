using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program
{
    class ParmeterTest      //给方法的重载
    {
        void DisplayResult(string result)
        {
            // implementation
        }

        void DisplayResult(int result)
        {
            // implementation
        }
    }
    class MyClass
    {
        int DoSomething(int x)
        {
            DoSomething(int x, int y);
        }
        int DoSomething(int x,int y)
        {
            // implementation
        }
    }
    
}
