using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program               //3.5 结构
{
    struct Dimensions       //创建一个结构类型
    {
        public double Length;
        public double Width;

        public Dimensions(double length,double width)
        {
            Length = length;
            Width = width;
        }

        public double Diagonal
        {
            get
            {
                return Math.Sqrt(Length * Length + Width * Width);
            }
        }
    }
    public class MyClass     //创建一个类
    {
        
    }
    
}
