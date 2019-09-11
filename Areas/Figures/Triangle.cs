using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Areas.Figures
{
    public class Triangle: Figure, IFigure
    {
        public Triangle(List<PointF> _points)
        {
            if(_points.Count == 3)
            {
                points = _points;
            }
            else
            {
                throw new ArgumentException("Not a triangle");
            }
        }
    }
}
