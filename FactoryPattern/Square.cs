using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class Square : Shape
    {
        public void draw()
        {
            Console.WriteLine("Inside Square draw() method.");
        }
    }
}
