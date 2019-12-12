using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Ingles : Idioma
    {
        private Dictionary<string, string> FrasesArray = new Dictionary<string, string>();

        public Ingles()
        {
            FrasesArray.Add("ListaVacia", "<h1>Empty list of shapes!</h1>");
            FrasesArray.Add("ReporteFormas", "<h1>Shapes report</h1>");
            FrasesArray.Add("Total", "TOTAL:<br/>");
            FrasesArray.Add("Area", "Area");
            FrasesArray.Add("Perimetro", "Perimeter");
            FrasesArray.Add("Formas", "shapes");
            FrasesArray.Add("CuadradoS", "Square");
            FrasesArray.Add("CuadradoP", "Squares");
            FrasesArray.Add("CirculoS", "Circle");
            FrasesArray.Add("CirculoP", "Circles");
            FrasesArray.Add("RectanguloS", "Rectangle");
            FrasesArray.Add("RectanguloP", "Rectangles");
            FrasesArray.Add("TrianguloS", "Triangle");
            FrasesArray.Add("TrianguloP", "Triangles");
            FrasesArray.Add("TrapecioS", "Trapezoid");
            FrasesArray.Add("TrapecioP", "Trapezoids");

            this.SetFrasesArray(FrasesArray);
            TipoIdioma = "Ingles";
        }
    }
}
