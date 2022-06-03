using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution.Entities.Language
{
    public class ShapeName
    {
        public ShapeIdentifier Identifier { get; }
        public string SingularName { get; }
        public string PluralName { get; }
        public ShapeName(ShapeIdentifier identifier, string singularName, string pluralName)
        {
            Identifier = identifier;
            SingularName = singularName;
            PluralName = pluralName;
        }
    }
}