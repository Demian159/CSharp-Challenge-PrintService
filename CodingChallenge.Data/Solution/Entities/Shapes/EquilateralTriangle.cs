using CodingChallenge.Data.Solution.Entities.Shapes;
using System;
using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution
{
    public class EquilateralTriangle : Shape
    {
        public int NumberOfSides => 3;
        public EquilateralTriangle(decimal sideWidth)
        {
            ShapeNameIdentifier = ShapeIdentifier.EquilateralTriangle;
            SideWidth = sideWidth > 0 ? sideWidth : throw new ArgumentException(nameof(SideWidth) + " value can't be zero or negative.");
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        protected override decimal CalculateArea()
        {
            return ((decimal)Math.Sqrt(NumberOfSides) / 4) * SideWidth * SideWidth;
        }

        protected override decimal CalculatePerimeter()
        {
            return SideWidth * NumberOfSides;
        }
    }
}
