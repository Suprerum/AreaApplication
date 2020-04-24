using System;
using System.Collections.Generic;
using System.Text;

namespace AreaCalculation
{
    public class Сircle : Figure
    {
        private double Radius { get; set; }

        public Сircle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * Math.Pow(Radius, 2);
        }
    }
}
