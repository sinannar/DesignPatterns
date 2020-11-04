using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class Context
    {
        private Strategy strategy;

        public Context(Strategy s)
        {
            strategy = s;
        }

        public  int executeStrategy(int num1, int num2)
        {
            return strategy.doOperation(num1, num2);
        }
    }
}
