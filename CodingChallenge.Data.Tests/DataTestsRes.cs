using System.Collections.Generic;
using System.Linq;
using CodingChallenge.Data.Classes;
using CodingChallenge.Data.Classes.Formas;
using NUnit.Framework;


namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTestsRes
    {
        private readonly Idioma eng = new Idioma()
        {
            FormasPlural = new Dictionary<string, string>()
            {
                { "Cuadrado", "Squares" },
                { "Triangulo", "Triangles" },
                { "Circulo", "Circles" },
                { "Trapecio", "Trapezoids" },
                { "Rectangulo", "Rectangles" }
            },
            Titulos = new Dictionary<string, string>()
            {
                { "Perimetro", "Perimeter" },
                { "Area", "Area" },
                {"Forma", "Shape" },
                { "Formas", "Shapes" }
            },
            Mensajes = new Dictionary<string, string>()
            {
                {"Vacio", "<h1>Empty list of shapes!</h1>" },
                {"Reporte", "<h1>Shapes report</h1>" },
                {"Total", "TOTAL:<br/>" }
            },
            Formas = new Dictionary<string,string>()
                {
                    { "Cuadrado", "Square" },
                    { "Triangulo", "Triangle" },
                    { "Circulo", "Circle" },
                    { "Trapecio", "Trapeze" },
                    { "Rectangulo", "Rectangle" }
                }
        };
        private readonly Idioma esp = new Idioma()
        {
            FormasPlural = new Dictionary<string, string>()
            {
                { "Cuadrado", "Cuadrados" },
                { "Triangulo", "Triangulos" },
                { "Circulo", "Circulos" },
                { "Trapecio", "Trapecios" },
                { "Rectangulo", "Rectangulos" }
            },
            Titulos = new Dictionary<string, string>()
            {
                { "Perimetro", "Perimetro" },
                { "Area", "Area" },
                {"Forma", "Forma" },
                { "Formas", "Formas" }
            },
            Mensajes = new Dictionary<string, string>()
            {
                {"Vacio", "<h1>Lista vacía de formas!</h1>" },
                {"Reporte", "<h1>Reporte de Formas</h1>" },
                {"Total", "TOTAL:<br/>" }
            },
            Formas = new Dictionary<string, string>()
                {
                    { "Cuadrado", "Cuadrado" },
                    { "Triangulo", "Triangulo" },
                    { "Circulo", "Circulo" },
                    { "Trapecio", "Trapecio" },
                    { "Rectangulo", "Rectangulo" }
                }
        };
        private readonly Idioma jsp = new Idioma()
        {
            FormasPlural = new Dictionary<string, string>()
            {
                { "Cuadrado", "せいほうけい" },
                { "Triangulo", "さんかく" },
                { "Circulo", "丸" },
                { "Trapecio", "台形" },
                { "Rectangulo", "長方形" }
            },
            Titulos = new Dictionary<string, string>()
            {
                { "Perimetro", "周り" },
                { "Area", "辺" },
                {"Forma", "形" },
                { "Formas", "形" }
            },
            Mensajes = new Dictionary<string, string>()
            {
                {"Vacio", "<h1>虚しい列挙</h1>" },
                {"Reporte", "<h1>形の表</h1>" },
                {"Total", "TOTAL:<br/>" }
            },
            Formas = new Dictionary<string, string>()
                {
                    { "Cuadrado", "せいほうけい" },
                    { "Triangulo", "さんかく" },
                    { "Circulo", "丸" },
                    { "Trapecio", "台形" },
                    { "Rectangulo", "長方形" }
                }
        };





        [TestCase]
        public void TestResumenListaVacia()
        {
            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                CrearReporte.Imprimir(new List<Forma>(), esp));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                CrearReporte.Imprimir(new List<Forma>(), eng));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {
            

            var cuadrados = new List<Forma> { new Cuadrado(5, esp) };
            

            var resumen = CrearReporte.Imprimir(cuadrados, cuadrados.First().Idioma);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 Forma Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            var cuadrados = new List<Forma>
            {
                new Cuadrado(5, eng),
                new Cuadrado(1, eng),
                new Cuadrado(3, eng)
            };

            var resumen = CrearReporte.Imprimir(cuadrados, eng);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 Shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            var formas = new List<Forma>
            {
                new Cuadrado(5, eng),
                new Circulo(3, eng),
                new Triangulo(4, eng),
                new Cuadrado(2, eng),
                new Triangulo(9, eng),
                new Circulo(2.75m, eng),
                new Triangulo(4.2m, eng)
            };

            var resumen = CrearReporte.Imprimir(formas, eng);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 13.01 | Perimeter 18.06 <br/>3 Triangles | Area 49.64 | Perimeter 51.6 <br/>TOTAL:<br/>7 Shapes Perimeter 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            var formas = new List<Forma>
            {
                new Cuadrado (5, esp),
                new Circulo (3, esp),
                new Triangulo(4, esp),
                new Cuadrado(2, esp),
                new Triangulo(9, esp),
                new Circulo (2.75m, esp),
                new Triangulo (4.2m, esp)
            };

            var resumen = CrearReporte.Imprimir(formas, esp);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Circulos | Area 13.01 | Perimetro 18.06 <br/>3 Triangulos | Area 49.64 | Perimetro 51.6 <br/>TOTAL:<br/>7 Formas Perimetro 97.66 Area 91.65",
                resumen);
        }

        [TestCase]
        public void TestResumenCirculoJapones()
        {
            var formas = new List<Forma>
            {
                new Circulo (3, jsp),
                
            };

            var resumen = CrearReporte.Imprimir(formas, jsp);

            Assert.AreEqual(
                "<h1>形の表</h1>1 丸 | 辺 7.07 | 周り 9.42 <br/>TOTAL:<br/>1 形 周り 9.42 辺 7.07",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConNuevasFormas()
        {
            var formas = new List<Forma>
            {
                new Rectangulo(2, 4, esp),
                new Trapecio(2,6,3,4, esp)
            };

            var resumen = CrearReporte.Imprimir(formas, esp);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Rectangulo | Area 8 | Perimetro 16 <br/>1 Trapecio | Area 18 | Perimetro 16 <br/>TOTAL:<br/>2 Formas Perimetro 32 Area 26", resumen);
        }
    }
}
