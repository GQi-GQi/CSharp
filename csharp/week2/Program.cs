using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program               //3.3.3 只读字段
{
    public class DocumentEditor     //创建一个类
    {
        public static readonly uint MaxDocunebts;

        static DocumentEditor()
        {
            MaxDocunebts = DoSomethingToFindOutMaxNumber();//未定义该方法
        }
    }
    
}
