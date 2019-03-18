using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern.ConcreteClasses
{
    class DeepFrying : CookStrategy
    {
        public override void Cook(string food)
        {
            Console.WriteLine($"Cooking {food} by Deep Frying");
        }
    }
}
