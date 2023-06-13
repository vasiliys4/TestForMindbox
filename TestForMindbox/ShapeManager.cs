using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestForMindbox
{
    public abstract class ShapeManager
    {
        public double Area { get; set; }
        public virtual double CalculateArea() 
        { 
            return Area; 
        }
    }
}
