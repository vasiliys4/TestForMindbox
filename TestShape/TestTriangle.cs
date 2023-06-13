using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestForMindbox;

namespace TestShape
{
    public class TestTriangle
    {
        [Fact]
        public void IsTriangleArea()
        {
            var triangle1 = new Triangle(3, 4, 5);
            var result1 = triangle1.CalculateArea();
            Assert.Equal(6.0, result1);
            var triangle2 = new Triangle(3, 3, 3);
            var result2 = triangle2.CalculateArea();
            Assert.Equal(3.897114317029974, result2);
        }
        [Fact]
        public void IsTriangleRectangular()
        {
            var triangle1 = new Triangle(3, 4, 5);
            var result1 = triangle1.ChekRectangular();
            Assert.Equal(true, result1);
            var triangle2 = new Triangle(3, 3, 3);
            var result2 = triangle2.ChekRectangular();
            Assert.Equal(false, result2);
        }
    }
}
