using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleClient.Structural.Decorator
{
    public class HouseBlend : IBeverage
    {
        public double GetCost() => 0.99;
        public string GetName() => this.GetType().Name;
    }
}
