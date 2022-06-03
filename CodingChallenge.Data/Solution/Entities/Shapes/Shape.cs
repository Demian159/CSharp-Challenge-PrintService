using CodingChallenge.Data.Solution.Entities.Language;
using System.Linq;
using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution.Entities.Shapes
{
    public abstract class Shape
    {
        public ShapeIdentifier ShapeNameIdentifier { get; protected set; }

        public decimal SideWidth { get; protected set; }

        public decimal Area { get; protected set; }

        public decimal Perimeter { get; protected set; }

        public string GetName(ILanguage language)
        {
            return language.ShapeNames.FirstOrDefault(sn => sn.Identifier.Equals(ShapeNameIdentifier)).SingularName;
        }

        protected abstract decimal CalculateArea();
        protected abstract decimal CalculatePerimeter();
    }
}