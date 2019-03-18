using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.ConcreteClasses
{
    class OvenBaking : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine($"Cooking {food}  by Oven Baking it");
        }
    }
}
