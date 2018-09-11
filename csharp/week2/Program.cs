using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Introduction = Wrox.ProCSharp.Basics;


class Test
{
    public static int Main()
    {
        Introduction::NamespaceExample NSEx = new Introduction.NamespaceExample();
        Console.WriteLine(NSEx.GetNamespace());
        Console.ReadLine();
        return 0;
    }
}

namespace Wrox.ProCSharp.Basics
{
    class NamespaceExample
    {
        public string GetNamespace()
        {
            return this.GetType().Namespace;
        }
    }
}
