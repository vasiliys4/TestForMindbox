using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForMindbox
{
    public class Triangle : ShapeManager
    {
        double FirstSide;
        double SecondSide;
        double ThirdSide;

        public Triangle(double a, double b, double c)
        {
            (FirstSide, SecondSide, ThirdSide) = (a, b, c);
        }

        public override double AreaofTheFigure()
        {
            double HalfMeter;
            HalfMeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Area = Math.Sqrt(HalfMeter * ((HalfMeter - FirstSide) * (HalfMeter - SecondSide) * (HalfMeter - ThirdSide)));
        }

        public bool ChekInRectangular(double a, double b, double c)
        {
            double[] SideLength = new double[3] {a, b, c};
            Array.Sort(SideLength);
            return Math.Pow(SideLength[0], 2) + Math.Pow(SideLength[1], 2) == Math.Pow(SideLength[2], 2);
        }
    }
}
