using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution.Entities.Shapes
{
    public class ShapeGroupDetail
    {
        public string ShapesName { get; set; }
        public ShapeIdentifier ShapesIdentifier { get; set; }
        public int Amount { get; set; }
        public decimal TotalArea { get; set; }
        public decimal TotalPerimeter { get; set; }
    }
}