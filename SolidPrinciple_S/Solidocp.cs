using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciple_S
{
    public abstract class Solidocp
    {
        public abstract double CalculateArea();
    }

    public class Rectangle : Solidocp
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public override double CalculateArea()
        {
            return Width * Height;
        }
    }


    public class Circle : Solidocp
    {
        public double Radius { get; set; }

        public override double CalculateArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }

    public class AreaCalculator
    {
        public double CalculateArea(Solidocp shape)
        {
            return shape.CalculateArea();
        }
    }


}
