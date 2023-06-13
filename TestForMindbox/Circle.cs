namespace TestForMindbox
{
    public class Circle : ShapeManager
    {
        public double Radius { get; set; }
        public Circle(double radius) 
        {
            Radius= radius;
        }
        public override double CalculateArea()
        {
            return Area = Math.PI * Math.Pow(Radius, 2);           
        }
    }
}