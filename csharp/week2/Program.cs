using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class CustomerAccount        //创建一个类
{
    public virtual decimal CalculatePrice()
    {
        return 0.1M;
    }
}

class GoldAccount: CustomerAccount
{
    public override decimal CalculatePrice()
    {
        return base.CalculatePrice() * 0.9M;
    }
}