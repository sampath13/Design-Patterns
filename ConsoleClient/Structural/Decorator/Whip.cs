using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Structural.Decorator
{
    public class Whip : AbstractCondimentDecorator
    {
        public Whip(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public override double GetCost() => 0.05 + this.beverage.GetCost();
    }
}
