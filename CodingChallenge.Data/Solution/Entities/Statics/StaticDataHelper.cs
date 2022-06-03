using CodingChallenge.Data.Solution.Entities.Language;
using System.Collections.Generic;

namespace CodingChallenge.Data.Solution.Entities.Statics
{
    public static class StaticDataHelper
    {
        public static List<ILanguage> languageOptions = new List<ILanguage> { new English(), new Spanish() };
        public static List<ShapeIdentifier> shapeIdentifierList = new List<ShapeIdentifier> { ShapeIdentifier.Square, ShapeIdentifier.Circle, ShapeIdentifier.EquilateralTriangle };
        public enum LanguageIdentifier
        {
            English,
            Spanish
        }
        public enum ShapeIdentifier
        {
            Square,
            Circle,
            EquilateralTriangle
        }
    }
}
