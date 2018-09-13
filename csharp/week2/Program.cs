using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class MyBaseClass        //创建一个类
{
    public int MyGroovyMethod()
    {
        return 1;
    }
}

public class MyDerivedClass: MyBaseClass
{
    public new int MyGroovyMethod()
    {
        return 0;
    }
}