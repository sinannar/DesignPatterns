using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryPattern
{
    public class ShapeFactory
    {
        public Shape getShape(string shapeType)
        {
            if (shapeType == null)
            {
                return null;
            }
            if (string.Equals(shapeType, "CIRCLE"))
            {
                return new Circle();

            }
            else if(string.Equals(shapeType, "RECTANGLE"))
            {
                return new Rectangle();
            }
            else if (string.Equals(shapeType, "SQUARE"))
            {
                return new Square();
            }
            return null;
        }
    }
}
