using ChainOfResponsibilityPattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ChainOfResponsibilityPattern.Concrete
{
    public class ErrorLogger : AbstractLogger
    {
        public ErrorLogger(int level)
        {
            this.level = level;
        }

        protected override void write(string message)
        {
            Console.WriteLine("Error Console::Logger: " + message);
        }
    }
}
