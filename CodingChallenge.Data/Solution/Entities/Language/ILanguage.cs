using System.Collections.Generic;
using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution.Entities.Language
{
    public interface ILanguage
    {
        string Name { get; }
        LanguageIdentifier LanguageIdentifier { get; }
        string EmptyListOfShapes { get; }
        string ShapesReport { get; }
        string FooterTotal { get; }
        string Shapes { get; }
        string Perimeter { get; }
        string Area { get; }
        string Amount { get; }
        List<ShapeName> ShapeNames { get; }
        string GetShapeName(ShapeIdentifier shapeNameIdentifier, int amount);
    }
}