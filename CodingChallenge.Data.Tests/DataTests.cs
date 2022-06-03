using CodingChallenge.Data.Solution;
using CodingChallenge.Data.Solution.Entities.Shapes;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using static CodingChallenge.Data.Solution.Entities.Statics.StaticDataHelper;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        private PrintShapeService _printShapeService;

        [SetUp]
        public void SetUp()
        {
            _printShapeService = new PrintShapeService();
        }

        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>", _printShapeService.Print(new List<Shape>(), LanguageIdentifier.Spanish));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>", _printShapeService.Print(new List<Shape>(), LanguageIdentifier.English));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            var cuadrados = new List<Shape> {new Square(5)};

            var actual = _printShapeService.Print(cuadrados, LanguageIdentifier.Spanish);

            var expected = "<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>Cantidad: 1 | Perimetro: 20 | Area: 25";

            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<Shape>
            {
                new Square(5),
                new Square(1),
                new Square(3)
            };

            var actual = _printShapeService.Print(cuadrados, LanguageIdentifier.English);

            var expected = "<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>Amount: 3 | Perimeter: 36 | Area: 35";

            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };

            var actual = _printShapeService.Print(formas, LanguageIdentifier.English);
            var expected = "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>Amount: 7 | Perimeter: 97.66 | Area: 91.65";

            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<Shape>
            {
                new Square(5),
                new Circle(3),
                new EquilateralTriangle(4),
                new Square(2),
                new EquilateralTriangle(9),
                new Circle(2.75m),
                new EquilateralTriangle(4.2m)
            };

            var actual = _printShapeService.Print(formas, LanguageIdentifier.Spanish);

            var expected = "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Circulos | Area 13.01 | Perimetro 18.06 <br/>3 Triángulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>Cantidad: 7 | Perimetro: 97.66 | Area: 91.65";

            Assert.AreEqual(expected, actual);
        }

        [TestCase]
        public void Shapes_WhenSideWidthEqualsZero_ShouldThrowArgumentException()
        {
            var ex = Assert.Throws<ArgumentException>(() => new Circle(0));

            Assert.That(ex.Message == "SideWidth value can't be zero or negative.");
        }
    }
}
