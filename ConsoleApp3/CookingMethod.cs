using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyDesignPattern
{
    class CookingMethod
    {
        private string Food;
        private CookStrategy _cookStrategy;

        public void SetCookStrategy(CookStrategy cookStrategy)
        {
            this._cookStrategy = cookStrategy;
        }

        public void SetFood(string food)
        {
            this.Food = food;
        }

        public void Cook()
        {
            _cookStrategy.Cook(Food);
            Console.WriteLine();
        }
    }
}
