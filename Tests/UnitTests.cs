using System;
using System.Threading.Tasks;
using Xunit;
using AreaCalculation;

namespace AreaCalculationTests
{
    public class UnitTests
    {
        [Fact]
        public async Task ShouldEqualTriangleAreas()
        {
            double p = (10 + 10 + 10) / 2;
            double area = Math.Sqrt(p * (p - 10) * (p - 10) * (p - 10));
            var figure = new Triangle(10, 10, 10);

            Assert.Equal(area, figure.GetArea());
        }
        [Fact]
        public async Task ShouldEqualCircleAreas()
        {
            double area = Math.PI * Math.Pow(5, 2);
            var figure = new Ñircle(5);

            Assert.Equal(area, figure.GetArea());
        }
        [Fact]
        public async Task ShouldCheckRectangular()
        {
            bool IsRectangular = true;
            var figure = new Triangle(3, 4, 5);

            Assert.Equal(IsRectangular, figure.IsRectangular());
        }
    }
}
