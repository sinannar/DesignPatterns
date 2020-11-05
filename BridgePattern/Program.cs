﻿using BridgePattern.Concrete;
using BridgePattern.Contract;
using System;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape redCircle = new Circle(100, 100, 10, new RedCircle());
            Shape greenCircle = new Circle(100, 100, 10, new GreenCircle());

            redCircle.draw();
            greenCircle.draw();
        }
    }
}
