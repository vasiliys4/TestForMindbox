namespace TestForMindbox
{
    class Circle : ShapeManager
    {
        double Radius;

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