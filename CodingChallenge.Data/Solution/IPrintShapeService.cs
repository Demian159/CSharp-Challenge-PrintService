using CodingChallenge.Data.Solution.Entities.Shapes;
using System.Collections.Generic;
using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution
{
    public interface IPrint
    {
        string Print(List<Shape> shapes, LanguageIdentifier language);
    }
}