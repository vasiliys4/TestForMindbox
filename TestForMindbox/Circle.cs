namespace TestForMindbox
{
    public class Circle : ShapeManager
    {
        public double Radius;
        public Circle(double r) 
        {
            Radius= r;
        }
        public double AreaofTheFigure()
        {
            return Area = Math.PI * Math.Pow(Radius, 2);           
        }
    }
}