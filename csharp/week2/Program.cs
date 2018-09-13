using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyBaseClass        //创建一个类
{
    public virtual string VirtualMethod()       //把一个基类函数声明为virtual，就可以在任何派生类中重写该函数（虚方法）
    {
        return "This menthod is virtual and define in MyBaseClass";
    }

    private string foreName;
    public virtual string ForeName      //虚属性
    {
        get { return foreName; }
        set { foreName = value; }
    }
}

public class MyDerivedClass: MyBaseClass
{
    public override string VirtualMethod()      //虚方法的重写
    {
        return "This method is an override defined in MyDerivedClass.";
    }
}