using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Castellano : Idioma
    {
        private Dictionary<string, string> FrasesArray = new Dictionary<string, string>();

        public Castellano()
        {
            FrasesArray.Add("ListaVacia", "<h1>Lista vacía de formas!</h1>");
            FrasesArray.Add("ReporteFormas", "<h1>Reporte de Formas</h1>");
            FrasesArray.Add("Total", "TOTAL:<br/>");
            FrasesArray.Add("Area", "Area");
            FrasesArray.Add("Perimetro", "Perimetro");
            FrasesArray.Add("Formas", "formas");
            FrasesArray.Add("CuadradoS", "Cuadrado");
            FrasesArray.Add("CuadradoP", "Cuadrados");
            FrasesArray.Add("CirculoS", "Circulo");
            FrasesArray.Add("CirculoP", "Circulos");
            FrasesArray.Add("RectanguloS", "Rectangulo");
            FrasesArray.Add("RectanguloP", "Rectangulos");
            FrasesArray.Add("TrianguloS", "Triangulo");
            FrasesArray.Add("TrianguloP", "Triangulos");
            FrasesArray.Add("TrapecioS", "Trapecio");
            FrasesArray.Add("TrapecioP", "Trapecios");

            this.SetFrasesArray(FrasesArray);
            TipoIdioma = "Castellano";
        }

    }
}
