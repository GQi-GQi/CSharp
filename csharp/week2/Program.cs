using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program               //3.10 扩展方法
{
    
    public static class MoneyEXtension
    {
        public static void AddToAmount(this Money money, decimal amountToAdd)
        {
            money.AddToAmount += amountToAdd;
        }
    }
}
