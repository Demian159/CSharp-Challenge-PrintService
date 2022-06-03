using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution.Entities.Shapes
{
    public class Square : Shape
    {
        public int NumberOfSides => 4;

        public Square(decimal sideWidth)
        {
            ShapeNameIdentifier = ShapeIdentifier.Square;
            SideWidth = sideWidth;
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
