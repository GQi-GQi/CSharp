using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program               //3.3.2.3 构造函数
{
    class MyClass      //给类MyClass添加一个构造函数
    {
        public MyClass()            //和类名一致（一般默认）
        {
            
        }
        private int number;
        public MyClass(int number)  //构造函数重载（编译器不会提供默认，需要自己第一）
        {
            this.number = number;
        }

    }
    
}
