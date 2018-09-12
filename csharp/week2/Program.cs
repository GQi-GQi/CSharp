using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Program               //3.9 Object类
{
    
    class MainEntryPoint    
    {
        static void Main(string[] args)
        {
            Money cash1 = new Money();
            cash1.Amount = 40m;
            Console.WriteLine("cash1.ToString() returns: " + cash1.ToString());
            Console.ReadLine();
        }
    }
    public class Money
    {
        private decimal amount;

        public decimal Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }
        public override string ToString()
        {
            return "$" + Amount.ToString();
        }

    }
         
    
}
