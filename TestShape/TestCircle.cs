using TestForMindbox;

namespace TestShape
{
    public class TestCircle
    {
        [Fact]
        public void IsCircleArea()
        {
            var circle1 = new Circle(1);
            var result1 = circle1.CalculateArea();
            Assert.Equal(Math.PI, result1);
            var circle2 = new Circle(2);
            var result2 = circle2.CalculateArea();
            Assert.Equal(Math.PI * 4, result2);
        }
    }
}