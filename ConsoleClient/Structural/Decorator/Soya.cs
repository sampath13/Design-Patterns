using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Structural.Decorator
{
    public class Soya : AbstractCondimentDecorator
    {
        public Soya(IBeverage beverage)
        {
            this.beverage = beverage;
        }

        public override double GetCost() => 0.10 + this.beverage.GetCost();
    }
}
