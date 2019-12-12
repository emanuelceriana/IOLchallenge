using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Italiano : Idioma, OperacionesIdiomas
    {
        private Dictionary<string, string> FrasesArray = new Dictionary<string, string>();

        public Italiano()
        {
            FrasesArray.Add("ListaVacia", "<h1>Elenco vuoto di forme!</h1>");
            FrasesArray.Add("ReporteFormas", "<h1>Rapporto di forme</h1>");
            FrasesArray.Add("Total", "TOTALE:<br/>");
            FrasesArray.Add("Area", "Area");
            FrasesArray.Add("Perimetro", "Perimetro");
            FrasesArray.Add("Formas", "forme");
            FrasesArray.Add("CuadradoS", "Quadrato");
            FrasesArray.Add("CuadradoP", "Quadrati");
            FrasesArray.Add("CirculoS", "Circolo");
            FrasesArray.Add("CirculoP", "Circoli");
            FrasesArray.Add("RectanguloS", "Rettangolo");
            FrasesArray.Add("RectanguloP", "Rettangoli");
            FrasesArray.Add("TrianguloS", "Triangolo");
            FrasesArray.Add("TrianguloP", "Triangoli");
            FrasesArray.Add("TrapecioS", "Trapezio");
            FrasesArray.Add("TrapecioP", "Trapezi");

            this.SetFrasesArray(FrasesArray);
            TipoIdioma = "Italiano";
        }
    }
}
