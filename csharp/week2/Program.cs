using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public interface IInterface1 { }        //接口1

public interface IInterface2 { }        //接口2
public class MyBaseClass
{

}
public  class MyDerivedClass: MyBaseClass           //继承的用法，MyDerivedClass派生自MyBaseClass
{
    //
}


public class MyDerivedClassTwo: MyDerivedClass,IInterface1,IInterface2     //类派生自接口或类，用逗号隔开
{

}

public struct MyDerivedStruct: IInterface1,IInterface2          //结构派生自接口
{

}
