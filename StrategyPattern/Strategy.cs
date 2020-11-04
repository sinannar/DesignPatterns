using System;
using System.Collections.Generic;
using System.Text;

namespace StrategyPattern
{
    public interface Strategy
    {
        int doOperation(int num1, int num2);
    }
}
