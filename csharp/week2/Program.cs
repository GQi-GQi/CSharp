using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public abstract class  GenericCustomer     //创建一个抽象的类
{
    private string name;
    public GenericCustomer(string name)
    {
        this.name = name;
    }

    
}

class Nevermore60Customer: GenericCustomer      //派生出来一个类
{
    private uint highCostMinutesUsed;
    public string referrerName;
    public Nevermore60Customer(string name,string referrerName)     
        : base(name)
    {
        this.referrerName = referrerName;
    }
    public Nevermore60Customer(string Name)
        : this(Name,"<None>")
    {
    }
}

class program2
{
    static void Main(string[] args)
    {
        Nevermore60Customer customer = new Nevermore60Customer("luoyaohui","laijunfu");
        Console.WriteLine("Name is " + customer.name + ",referrerName is" + customer.referrerName);
        return;
    }
}