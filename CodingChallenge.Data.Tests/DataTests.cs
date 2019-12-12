using System;
using System.Collections.Generic;
using CodingChallenge.Data.Classes;
using NUnit.Framework;

namespace CodingChallenge.Data.Tests
{
    [TestFixture]
    public class DataTests
    {
        [TestCase]
        public void TestResumenListaVacia()
        {
            Idioma castellano = new Castellano();

            Assert.AreEqual("<h1>Lista vacía de formas!</h1>",
                ControladorReporte.Imprimir(new List<OperacionesFiguras>(), castellano));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnIngles()
        {
            Idioma ingles = new Ingles();

            Assert.AreEqual("<h1>Empty list of shapes!</h1>",
                ControladorReporte.Imprimir(new List<OperacionesFiguras>(), ingles));
        }

        [TestCase]
        public void TestResumenListaVaciaFormasEnItaliano()
        {
            Idioma italiano = new Italiano();

            Assert.AreEqual("<h1>Elenco vuoto di forme!</h1>",
                ControladorReporte.Imprimir(new List<OperacionesFiguras>(), italiano));
        }

        [TestCase]
        public void TestResumenListaConUnCuadrado()
        {

            Cuadrado cuadrado = new Cuadrado();
            double[] lados = { 5, 5, 5, 5 };
            cuadrado.SetLados(lados);

            Idioma castellano = new Castellano();

            var formas = new List<OperacionesFiguras>
            {
                cuadrado
            };

            var resumen = ControladorReporte.Imprimir(formas, castellano);

            Assert.AreEqual("<h1>Reporte de Formas</h1>1 Cuadrado | Area 25 | Perimetro 20 <br/>TOTAL:<br/>1 formas Perimetro 20 Area 25", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasCuadrados()
        {
            Cuadrado cu1 = new Cuadrado();
            double[] lcu1 = { 5, 5, 5, 5 };
            cu1.SetLados(lcu1);

            Cuadrado cu2 = new Cuadrado();
            double[] lcu2 = { 1, 1, 1, 1 };
            cu2.SetLados(lcu2);

            Cuadrado cu3 = new Cuadrado();
            double[] lcu3 = { 3, 3, 3, 3 };
            cu3.SetLados(lcu3);

            Idioma ingles = new Ingles();

            var cuadrados = new List<OperacionesFiguras>
            {
                cu1,
                cu2,
                cu3
            };

            var resumen = ControladorReporte.Imprimir(cuadrados, ingles);

            Assert.AreEqual("<h1>Shapes report</h1>3 Squares | Area 35 | Perimeter 36 <br/>TOTAL:<br/>3 shapes Perimeter 36 Area 35", resumen);
        }

        [TestCase]
        public void TestResumenListaConUnTrapecio()
        {

            double[] bases = { 5, 4 };
            double[] lados = { 5, 4, 3, 3.2 };

            TrapecioRectangulo trapecio = new TrapecioRectangulo
            {
                Altura = 3
            };

            trapecio.SetBases(bases);
            trapecio.SetLados(lados);

            Idioma italiano = new Italiano();

            var formas = new List<OperacionesFiguras>
            {
                trapecio
            };

            var resumen = ControladorReporte.Imprimir(formas, italiano);

            Assert.AreEqual("<h1>Rapporto di forme</h1>1 Trapezio | Area 13,5 | Perimetro 15,2 <br/>TOTALE:<br/>1 forme Perimetro 15,2 Area 13,5", resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTipos()
        {
            Cuadrado cu1 = new Cuadrado();
            double[] lcu1 = { 5, 5, 5, 5 };
            cu1.SetLados(lcu1);
            Circulo ci1 = new Circulo()
            {
                Radio = 3
            };
            TrianguloEquilatero tri1 = new TrianguloEquilatero();
            double[] ltri1 = { 4, 4, 4 };
            tri1.SetLados(ltri1);
            Cuadrado cu2 = new Cuadrado();
            double[] lcu2 = { 2, 2, 2, 2 };
            cu2.SetLados(lcu2);
            TrianguloEquilatero tri2 = new TrianguloEquilatero();
            double[] ltri2 = { 9, 9, 9 };
            tri2.SetLados(ltri2);
            Circulo ci2 = new Circulo()
            {
                Radio = 2.75d
            };
            TrianguloEquilatero tri3 = new TrianguloEquilatero();
            double[] ltri3 = { 4.2d, 4.2d, 4.2d };
            tri3.SetLados(ltri3);

            Idioma castellano = new Castellano();

            var formas = new List<OperacionesFiguras>
            {
                cu1,
                ci1,
                tri1,
                cu2,
                tri2,
                ci2,
                tri3
            };

            Idioma ingles = new Ingles();

            var resumen = ControladorReporte.Imprimir(formas, ingles);

            Assert.AreEqual(
                "<h1>Shapes report</h1>2 Squares | Area 29 | Perimeter 28 <br/>2 Circles | Area 52,03 | Perimeter 36,13 <br/>3 Triangles | Area 49,64 | Perimeter 51,6 <br/>TOTAL:<br/>7 shapes Perimeter 115,73 Area 130,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnCastellano()
        {
            Cuadrado cu1 = new Cuadrado();
            double[] lcu1 = { 5, 5, 5, 5 };
            cu1.SetLados(lcu1);
            Circulo ci1 = new Circulo()
            {
                Radio = 3
            };
            TrianguloEquilatero tri1 = new TrianguloEquilatero();
            double[] ltri1 = { 4, 4, 4 };
            tri1.SetLados(ltri1);
            Cuadrado cu2 = new Cuadrado();
            double[] lcu2 = { 2, 2, 2, 2 };
            cu2.SetLados(lcu2);
            TrianguloEquilatero tri2 = new TrianguloEquilatero();
            double[] ltri2 = { 9, 9, 9 };
            tri2.SetLados(ltri2);
            Circulo ci2 = new Circulo()
            {
                Radio = 2.75d
            };
            TrianguloEquilatero tri3 = new TrianguloEquilatero();
            double[] ltri3 = { 4.2d, 4.2d, 4.2d };
            tri3.SetLados(ltri3);

            Idioma castellano = new Castellano();

            var formas = new List<OperacionesFiguras>
            {
                cu1,
                ci1,
                tri1,
                cu2,
                tri2,
                ci2,
                tri3
            };

            var resumen = ControladorReporte.Imprimir(formas, castellano);

            Assert.AreEqual(
                "<h1>Reporte de Formas</h1>2 Cuadrados | Area 29 | Perimetro 28 <br/>2 Circulos | Area 52,03 | Perimetro 36,13 <br/>3 Triangulos | Area 49,64 | Perimetro 51,6 <br/>TOTAL:<br/>7 formas Perimetro 115,73 Area 130,67",
                resumen);
        }

        [TestCase]
        public void TestResumenListaConMasTiposEnItaliano()
        {
            Cuadrado cu1 = new Cuadrado();
            double[] lcu1 = { 5, 5, 5, 5 };
            cu1.SetLados(lcu1);
            Circulo ci1 = new Circulo()
            {
                Radio = 3
            };
            TrianguloEquilatero tri1 = new TrianguloEquilatero();
            double[] ltri1 = { 4, 4, 4 };
            tri1.SetLados(ltri1);
            Cuadrado cu2 = new Cuadrado();
            double[] lcu2 = { 2, 2, 2, 2 };
            cu2.SetLados(lcu2);
            TrianguloEquilatero tri2 = new TrianguloEquilatero();
            double[] ltri2 = { 9, 9, 9 };
            tri2.SetLados(ltri2);
            Circulo ci2 = new Circulo()
            {
                Radio = 2.75d
            };
            TrianguloEquilatero tri3 = new TrianguloEquilatero();
            double[] ltri3 = { 4.2d, 4.2d, 4.2d };
            tri3.SetLados(ltri3);

            Idioma italiano = new Italiano();

            var formas = new List<OperacionesFiguras>
            {
                cu1,
                ci1,
                tri1,
                cu2,
                tri2,
                ci2,
                tri3
            };

            var resumen = ControladorReporte.Imprimir(formas, italiano);

            Assert.AreEqual(
                "<h1>Rapporto di forme</h1>2 Quadrati | Area 29 | Perimetro 28 <br/>2 Circoli | Area 52,03 | Perimetro 36,13 <br/>3 Triangoli | Area 49,64 | Perimetro 51,6 <br/>TOTALE:<br/>7 forme Perimetro 115,73 Area 130,67",
                resumen);
        }

        [TestCase]
        public void TestInterfaceTriangulo()
        {
            double[] lados = { 2, 2, 2 };

            TrianguloEquilatero te = new TrianguloEquilatero();
            te.SetLados(lados);

            Assert.AreEqual(1.73, te.GetArea());
            Assert.AreEqual(6, te.GetPerimetro());
            Assert.AreEqual("Triangulo", te.Tipo);
        }

        [TestCase]
        public void TestInterfaceRectangulo()
        {
            double[] bases = { 2 };

            Rectangulo re = new Rectangulo
            {
                Altura = 3
            };

            re.SetBases(bases);

            Assert.AreEqual(6, re.GetArea());
            Assert.AreEqual(10, re.GetPerimetro());
            Assert.AreEqual("Rectangulo", re.Tipo);
        }

        [TestCase]
        public void TestInterfaceCuadrado()
        {
            double[] lados = { 5 };

            Cuadrado cu = new Cuadrado();

            cu.SetLados(lados);

            Assert.AreEqual(25, cu.GetArea());
            Assert.AreEqual(20, cu.GetPerimetro());
            Assert.AreEqual("Cuadrado", cu.Tipo);
        }

        [TestCase]
        public void TestInterfaceCirculo()
        {
            Circulo ci = new Circulo
            {
                Radio = 3
            };

            Assert.AreEqual(28.27, ci.GetArea());
            Assert.AreEqual(18.85, ci.GetPerimetro());
            Assert.AreEqual("Circulo", ci.Tipo);
        }

        [TestCase]
        public void TestInterfaceTrapecioRectangulo()
        {
            double[] bases = { 5, 4 };
            double[] lados = { 5, 4, 3, 3.2 };

            TrapecioRectangulo tr = new TrapecioRectangulo
            {
                Altura = 3
            };

            tr.SetBases(bases);
            tr.SetLados(lados);

            Assert.AreEqual(13.5, tr.GetArea());
            Assert.AreEqual(15.2, tr.GetPerimetro());
            Assert.AreEqual("Trapecio", tr.Tipo);
        }

    }
}
