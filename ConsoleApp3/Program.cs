using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            MoneyValue moneyValueObject = new MoneyValue(10.75m);
            Console.WriteLine("Cents: {0}, Dollars: {1}", moneyValueObject.Cents, moneyValueObject.Dollars);
            Console.ReadLine();
        }
    }
}
