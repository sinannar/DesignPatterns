using System;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 10;
            int num2 = 5;

            Context context = new Context(new OperationAdd());
            Console.WriteLine($"{num1} + {num2} = {context.executeStrategy(num1, num2)}");

            context = new Context(new OperationSubstract());
            Console.WriteLine($"{num1} - {num2} = {context.executeStrategy(num1, num2)}");

            context = new Context(new OperationMultiply());
            Console.WriteLine($"{num1} * {num2} = {context.executeStrategy(num1, num2)}");
        }
    }
}
