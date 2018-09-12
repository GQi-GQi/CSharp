using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program               //3.3.2.3 构造函数（构造函数调用其他构造函数）
{
    public class Car     //创建一个类
    {
        private string description;
        private uint nWheels;
        public Car(string description,uint nWheel)
        {
            this.description = description;
            this.nWheels = nWheels;
        }

        public Car(string description)
        {
            this.description = description;
            this.nWheels = 4;
        }
    }
    
}
