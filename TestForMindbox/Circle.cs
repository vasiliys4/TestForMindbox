namespace TestForMindbox
{
    class Circle : ShapeManager
    {
        public double AreaofTheFigure(double[] SideLength)
        {
            return Math.PI * Math.Pow(SideLength[0], 2);           
        }
    }
}