using System;
using System.Collections.Generic;
using System.Text;

namespace Areas
{
    public static class AreasCalculator
    {
        public static float GetArea(IFigure figure)
        {
            return figure.GetArea();
        }
    }
}
