using System.Collections.Generic;
using System.Drawing;

namespace Areas
{
    public class Figure : IFigure
    {
        protected List<PointF> points;

        public Figure()
        {

        }
        public Figure(List<PointF> points)
        {
            this.points = points;
        }
        public float GetArea()
        {
            float area = 0;
            int j = points.Count - 1;
            for (int i = 0; i < points.Count; i++)
            {
                area = area + (points[j].X + points[i].X) * (points[j].Y + points[i].Y);
                j = i;  //j is previous vertex to i
            }
            return area / 2;
        }
    }
}
