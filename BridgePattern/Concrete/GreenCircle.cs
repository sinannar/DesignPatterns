using BridgePattern.Contract;
using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Concrete
{
    public class GreenCircle : DrawAPI
    {
        public void drawCircle(int radius, int x, int y)
        {
            Console.WriteLine($"Drawing Circle [color:green, radius: {radius}, x:{x}, y:{y} ]");
        }
    }
}
