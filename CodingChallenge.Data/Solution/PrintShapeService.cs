using CodingChallenge.Data.Solution.Entities.Language;
using CodingChallenge.Data.Solution.Entities.Shapes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Solution
{
    public class PrintShapeService : IPrint
    {
        public ILanguage Language { get; set; }

        public string Print(List<Shape> shapes, LanguageIdentifier selectedLanguage)
        {
            Language = GetSelectedLanguage(selectedLanguage);

            var stringBuilder = new StringBuilder();

            if (!shapes.Any()) return stringBuilder.Append(Language.EmptyListOfShapes).ToString();

            stringBuilder.Append(Language.ShapesReport);

            var shapeGroupDetails = GetShapeGroupDetailsList(shapes.GroupBy(s => s.ShapeNameIdentifier));

            shapeGroupDetails.ForEach(sdg => stringBuilder.Append(GetShapesDescriptionLine(Language, sdg.ShapesIdentifier, sdg.Amount, sdg.TotalArea, sdg.TotalPerimeter)));

            stringBuilder.Append(Language.FooterTotal);

            stringBuilder.Append($"{Language.Amount}: {shapeGroupDetails.Sum(sg => sg.Amount)} | {Language.Perimeter}: {shapeGroupDetails.Sum(sg => sg.TotalPerimeter).ToString("#.##")} | {Language.Area}: {shapeGroupDetails.Sum(sg => sg.TotalArea).ToString("#.##")}");

            return stringBuilder.ToString();
        }

        private List<ShapeGroupDetail> GetShapeGroupDetailsList(IEnumerable<IGrouping<ShapeIdentifier,Shape>> shapesGroupByIdentifier)
        {
            var shapeDetailsGroupByIdentifier = new List<ShapeGroupDetail>();

            foreach (var shapeGroup in shapesGroupByIdentifier)
            {
                shapeDetailsGroupByIdentifier.Add(GetShapeDetails(shapeGroup));
            }

            return shapeDetailsGroupByIdentifier;
        }

        private ShapeGroupDetail GetShapeDetails(IEnumerable<Shape> shapeGroup)
        {
            var shapeListDetails = new ShapeGroupDetail();

            var shapeExample = shapeGroup.FirstOrDefault();

            shapeListDetails.ShapesName = shapeExample.GetName(Language);
            shapeListDetails.ShapesIdentifier = shapeExample.ShapeNameIdentifier;
            shapeListDetails.Amount = shapeGroup.Count();
            shapeListDetails.TotalArea = shapeGroup.Sum(s => s.Area);
            shapeListDetails.TotalPerimeter = shapeGroup.Sum(s => s.Perimeter);

            return shapeListDetails;
        }

        private ILanguage GetSelectedLanguage(LanguageIdentifier selectedLanguage)
        {
            return languageOptions.FirstOrDefault(lp => lp.LanguageIdentifier.Equals(selectedLanguage));
        }

        public string GetShapesDescriptionLine(ILanguage language, ShapeIdentifier shapeNameIdentifier, int amount, decimal area, decimal perimeter)
        {
            return $"{amount} {language.GetShapeName(shapeNameIdentifier, amount)} | {language.Area} {area:#.##} | {language.Perimeter} {perimeter:#.##} <br/>";
        }
    }
}
