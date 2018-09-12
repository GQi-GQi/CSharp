using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program               //3.6 弱引用
{
    public class MyClass     //创建一个类
    {
        static void Main()
        {
            WeakReference mathReference = new WeakReference(new MathTest());        //弱引用WeakReference使用
            MathTest math;
            if(mathReference.IsAlive)
            {
                math = mathReference.Target as MathTest;
                math.Value = 30;
            }
            else
            {
                Console.WriteLine("Reference is not available.");
            }
            return;
        }
        class MathTest
        {
            public int Value;
        }
        
    }
    
}
