using ConsoleClient.Structural.Decorator;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient
{
    class Program
    {
        static void Main(string[] args)
        {
            TestDecorator();
            Console.ReadKey();
        }

        static void TestDecorator()
        {
            IBeverage beverage = new Espresso();
            beverage = new Mocha(beverage);
            beverage = new Mocha(beverage);
            beverage = new Whip(beverage);
            Console.WriteLine($"Cost:{{{beverage.GetCost()}}}");
            Console.WriteLine($"Order details: {beverage.GetName()}");
        }
    }
}
