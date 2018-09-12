using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program               //3.8 静态类
{
    
    static class StaticUtilities     //创建一个静态类
    {
        public void MethodOne()
        {

        }
    }


    partial class MyClasss    //在另个.cs文件创建同名类(编译的时候会合成同一个类）
    {
        public void MethodTwo()
        {

        }
    }
    
}
