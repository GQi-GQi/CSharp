using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

sealed class CustomerAccount        //创建一个密封类（不能继承该类）
{
    public sealed override void FinalMethod()
    {

    }
}

class DerivedClass: CustomerAccount     //不能派生密封类
{
    public sealed override void FinalMethod()   //不能重写密封方法S
    {

    }
}