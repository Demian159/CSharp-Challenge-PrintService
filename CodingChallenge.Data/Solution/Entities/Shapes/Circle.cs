using System;
using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution.Entities.Shapes
{
    public class Circle : Shape
    {
        public Circle(decimal sideWidth)
        {
            ShapeNameIdentifier = ShapeIdentifier.Circle;
            SideWidth = sideWidth > 0 ? sideWidth :  throw new ArgumentException(nameof(SideWidth) + " value can't be zero or negative.");
            Area = CalculateArea();
            Perimeter = CalculatePerimeter();
        }

        protected override decimal CalculateArea()
        {
            return (decimal)Math.PI * (SideWidth / 2) * (SideWidth / 2);
        }

        protected override decimal CalculatePerimeter()
        {
            return (decimal)Math.PI * SideWidth;
        }
    }
}
