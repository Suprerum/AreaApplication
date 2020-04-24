using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AreaCalculation
{
    public class Triangle : Figure
    {
        private double SideA { get; set; }
        private double SideB { get; set; }
        private double SideC { get; set; }

        public Triangle(double sideA, double sideB, double sideC)
        {
            this.SideA = sideA;
            this.SideB = sideB;
            this.SideC = sideC;
        }

        public override double GetArea()
        {
            double p = (SideA + SideB + SideC) / 2;
            return Math.Sqrt(p * (p - SideA) * (p - SideB) * (p - SideC));
        }

        public bool IsRectangular()
        {
            List<double> sides = new List<double> { SideA, SideB, SideC };
            var maxSide = sides.Max();
            sides.Remove(maxSide);
            return (Math.Pow(maxSide, 2) == Math.Pow(sides[0], 2) + Math.Pow(sides[1], 2));
        }
    }
}
