using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForMindbox
{
    class Triangle : ShapeManager
    {
        //double FirstSide = double.Parse(Console.ReadLine());
        //double SecondSide = double.Parse(Console.ReadLine());
        //double ThirdSide = double.Parse(Console.ReadLine());

        public double AreaofTheFigure(double[] SideLength)
        {
            //SideLength = new double[3] {FirstSide, SecondSide, ThirdSide};
            double HalfMeter;
            HalfMeter = (SideLength[0] + SideLength[1] + SideLength[2]) / 2;
            return Math.Sqrt(HalfMeter * ((HalfMeter - SideLength[0]) * (HalfMeter - SideLength[1]) * (HalfMeter - SideLength[2])));
        }

        public bool ChekInRectangular(double[] SideLength)
        {
            //SideLength = new double[3] {FirstSide, SecondSide ,ThirdSide};
            Array.Sort(SideLength);
            return Math.Pow(SideLength[0], 2) + Math.Pow(SideLength[1], 2) == Math.Pow(SideLength[2], 2);
            //SquareTriangle = FirstSide * SecondSide / 2;
        }
    }
}
