using System;
using System.Collections.Generic;
using System.Text;

namespace BridgePattern.Contract
{
    public abstract class Shape
    {
        protected DrawAPI drawAPI;

        public Shape(DrawAPI a)
        {
            drawAPI = a;
        }

        public abstract void draw();
    }
}
