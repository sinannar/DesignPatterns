using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Rectangle : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Rectangle draw() method.");
        }
    }
}
