using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Circle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Circle draw() method.");
        }
    }
}
