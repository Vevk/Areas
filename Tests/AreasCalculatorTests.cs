using Areas.Figures;
using System;
using System.Collections.Generic;
using System.Drawing;
using Xunit;

namespace Tests
{
    public class AreasCalculatorTests
    {
        [Fact]
        public void Circle_GetArea()
        {
            //arrange
            var c = new Circle(1);
            //act
            var res = c.GetArea();

            //assert
            Assert.Equal(res, Math.PI, 5);
        }

        [Fact]
        public void Triangle_Initilization_Failure()
        {
            //arrange
            var args = new List<PointF>() { };

            //act
            Action act = () => new Triangle(args);

            //assert
            var exc = Assert.Throws<ArgumentException>(act);
        }

        public static IEnumerable<object[]> GetTrianglePoints()
        {
            yield return new object[] { new PointF(0, 0), new PointF(0, 1), new PointF(1, 0), 0.5 };
            yield return new object[] { new PointF(0, 0), new PointF(0, 1), new PointF(0, 0), 0 };
            yield return new object[] { new PointF(0, 0), new PointF(0, 4), new PointF(2, 0), 4 };
            yield return new object[] { new PointF(0, 0), new PointF(0, -1), new PointF(-1, 0), 0.5 };
        }

        [Theory]
        [MemberData(nameof(GetTrianglePoints))]
        public void Triangle_GetArea(
            PointF point1, 
            PointF point2, 
            PointF point3, 
            float ans)
        {
            //arrange
            var args = new List<PointF>() { point1, point2, point3 };
            var triangle = new Triangle(args);

            //act
            var res = triangle.GetArea();

            //assert
            Assert.Equal(res, ans, 5);
        }

        public static IEnumerable<object[]> GetFigurePoints()
        {
            yield return new object[] { new List<PointF>() { new PointF(0, 0), new PointF(0, 1), new PointF(1, 0) }, 0.5 } ;
            yield return new object[] { new List<PointF>() { new PointF(0, 0), new PointF(0, 1), new PointF(1, 1), new PointF(1, 0) }, 1 };
        }

        [Theory]
        [MemberData(nameof(GetFigurePoints))]
        public void Figure_GetArea(List<PointF> points, float ans)
        {
            //arrange
            var args = new List<PointF>(points);
            var f = new Areas.Figure(args);

            //act
            var res = f.GetArea();

            //assert
            Assert.Equal(ans, res, 5);
        }
    }
}
