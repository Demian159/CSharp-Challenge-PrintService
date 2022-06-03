using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;
using System.Collections.Generic;
using System.Linq;

namespace CodingChallenge.Data.Solution.Entities.Language
{
    public class English : ILanguage
    {
        public string Name => "English";
        public LanguageIdentifier LanguageIdentifier => LanguageIdentifier.English;
        public string EmptyListOfShapes => "<h1>Empty list of shapes!</h1>";
        public string ShapesReport => "<h1>Shapes report</h1>";
        public string FooterTotal => "TOTAL:<br/>";
        public string Shapes => "Shapes";
        public string Area => "Area";
        public string Perimeter => "Perimeter";
        public string Amount => "Amount";
        public List<ShapeName> ShapeNames =>
            new List<ShapeName>
            {
                new ShapeName(ShapeIdentifier.Square, "Square", "Squares" ),
                new ShapeName(ShapeIdentifier.Circle, "Circle", "Circles" ),
                //TODO Should be "Equilateral Triangle"
                new ShapeName(ShapeIdentifier.EquilateralTriangle, "Triangle", "Triangles" ),
            };

        public string GetShapeName(ShapeIdentifier shapeNameIdentifier, int amount)
        {
            var shapeName = ShapeNames.FirstOrDefault(sn => sn.Identifier.Equals(shapeNameIdentifier));
            return amount == 1 ? shapeName.SingularName : shapeName.PluralName;
        }
    }
}
