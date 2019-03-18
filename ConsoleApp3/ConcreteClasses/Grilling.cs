using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.ConcreteClasses
{
    class Grilling : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine($"Cooking {food}  by Grilling it");
        }
    }
}
