using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Structural.Decorator
{
    public abstract class AbstractCondimentDecorator : IBeverage
    {
        protected IBeverage beverage;
        public abstract double GetCost();
        public string GetName() => $"{beverage.GetName()}, {this.GetType().Name}";
    }
}
