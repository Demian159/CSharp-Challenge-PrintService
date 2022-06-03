using System;
using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution.Entities.Shapes
{
    public class Square : Shape
    {
        public int NumberOfSides => 4;

        public Square(decimal sideWidth)
        {
            ShapeNameIdentifier = ShapeIdentifier.Square;
            SideWidth = sideWidth > 0 ? sideWidth : throw new ArgumentException(nameof(SideWidth) + " value can't be zero or negative.");
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        protected override decimal CalculateArea()
        {
            return SideWidth * SideWidth;
        }
        protected override decimal CalculatePerimeter()
        {
            return SideWidth * NumberOfSides;
        }

    }
}
