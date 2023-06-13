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
            if ((FirstSide + SecondSide > ThirdSide) &&
                (FirstSide + ThirdSide > SecondSide) &&
                (SecondSide + ThirdSide > FirstSide) &&
                FirstSide > 0 &&
                SecondSide > 0 &&
                ThirdSide > 0)
            {
                if (ChekRectangular())
                {
                    Console.WriteLine("Треугольник прямоугольный");
                }
            }
            else
            {
                Console.WriteLine("Треугольник не существует");
            }
        }

        public override double CalculateArea()
        {
            double HalfMeter;
            HalfMeter = (FirstSide + SecondSide + ThirdSide) / 2;
            return Area = Math.Sqrt(HalfMeter * ((HalfMeter - FirstSide) * (HalfMeter - SecondSide) * (HalfMeter - ThirdSide)));
        }

        public bool ChekRectangular()
        {
            double[] SideLength = new double[3] {FirstSide ,SecondSide ,ThirdSide};
            Array.Sort(SideLength);
            return Math.Pow(SideLength[0], 2) + Math.Pow(SideLength[1], 2) == Math.Pow(SideLength[2], 2);
        }
    }
}
