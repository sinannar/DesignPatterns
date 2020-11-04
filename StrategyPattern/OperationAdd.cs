using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public class OperationAdd : Strategy
    {
        public int doOperation(int num1, int num2)
        {
            return num1 + num2;
        }
    }
}
