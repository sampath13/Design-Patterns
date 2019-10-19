using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Structural.Decorator
{
    public class Mocha : AbstractCondimentDecorator
    {
        public Mocha(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public override double GetCost() => 0.20 + this.beverage.GetCost();
    }
}
