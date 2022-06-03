using System.Collections.Generic;
using System.Linq;
using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution.Entities.Language
{
    public class Spanish : ILanguage
    {
        public string Name => "Spanish";
        public LanguageIdentifier LanguageIdentifier => LanguageIdentifier.Spanish;
        public string EmptyListOfShapes => "<h1>Lista vacía de formas!</h1>";
        public string ShapesReport => "<h1>Reporte de Formas</h1>";
        public string FooterTotal => "TOTAL:<br/>";
        public string Shapes => "Formas";
        public string Area => "Area";
        public string Perimeter => "Perimetro";
        public string Amount => "Cantidad";
        public List<ShapeName> ShapeNames =>
            new List<ShapeName>
            {
                new ShapeName(ShapeIdentifier.Square, "Cuadrado", "Cuadrados" ),
                new ShapeName(ShapeIdentifier.Circle, "Circulo", "Circulos" ),
                new ShapeName(ShapeIdentifier.EquilateralTriangle, "Triángulo", "Triángulos" ),
            };

        public string GetShapeName(ShapeIdentifier shapeNameIdentifier, int amount)
        {
            var shapeName = ShapeNames.FirstOrDefault(sn => sn.Identifier.Equals(shapeNameIdentifier));
            return amount == 1 ? shapeName.SingularName : shapeName.PluralName;
        }
    }
}
