using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Areas.Figures
{
    public class Circle : IFigure
    {
        public float Radius { get; }
        public Circle(float radius)
        {
            Radius = radius;
        }

        public float GetArea()
        {
            return (float)Math.PI * Radius * Radius;
        }
    }
}
