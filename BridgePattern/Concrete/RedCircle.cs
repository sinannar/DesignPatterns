using BridgePattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Concrete
{
    public class RedCircle : DrawAPI
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Circle [color:red, radius: {radius}, x:{x}, y:{y} ]");
        }
    }
}
