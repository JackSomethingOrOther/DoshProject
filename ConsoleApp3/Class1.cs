using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public class MoneyValue
    {
        public int Dollars { get; set; }
        public int Cents { get; set; }

        public MoneyValue(decimal Money)
        {
            decimal Test = Math.Truncate(Money);
            Cents = (int)(((Money - Test) * 100));
            Dollars = (int)Test;
        }

        public void IncrementMoney()
        {

        }

        public void DecrementMoney()
        {

        }
    }
}
