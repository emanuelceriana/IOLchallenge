using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Reporte
    {
        private Dictionary<string, int> CantidadFiguras = new Dictionary<string, int>();
        private Dictionary<string, double> AreaFiguras = new Dictionary<string, double>();
        private Dictionary<string, double> PerimetroFiguras = new Dictionary<string, double>();

        private StringBuilder sb = new StringBuilder();
        private Dictionary<string, string> frases;

        public Reporte(List<OperacionesFiguras> figuras, Idioma idioma)
        {
            frases = idioma.GetFrasesArray();

            foreach (FiguraGeometrica fg in figuras)
            {
                if (!this.CantidadFiguras.ContainsKey(fg.Tipo)){
                    this.CantidadFiguras.Add(fg.Tipo, 0);
                    this.AreaFiguras.Add(fg.Tipo, 0);
                    this.PerimetroFiguras.Add(fg.Tipo, 0);
                }
            }
        }

        public void SetCantidad(string figura)
        {
            CantidadFiguras[figura] += 1;
        }

        public void SetArea(string figura, double area)
        {
            AreaFiguras[figura] += area;
        }

        public void SetPerimetro(string figura, double perimetro)
        {
            PerimetroFiguras[figura] += perimetro;
        }

        public string Print()
        {
            return sb.ToString();
        }

        public void HeaderReporte(string text) 
        {
            sb.Append(frases[text]);
        }

        public void BodyReporte()
        {
            foreach (KeyValuePair<string, int> figura in CantidadFiguras)
            {
                sb.Append($"{figura.Value} {Pluralizador(figura.Key,figura.Value)} | {frases["Area"]} {AreaFiguras[figura.Key]:#.##} | {frases["Perimetro"]} {PerimetroFiguras[figura.Key]:#.##} <br/>");
            }
        }

        public void FooterReporte()
        {
            sb.Append(frases["Total"]);
            int cantidadTotal = 0;
            double perimetroTotal = 0;
            double areaTotal = 0;

            foreach (KeyValuePair<string, int> figura in CantidadFiguras)
            {
                cantidadTotal += figura.Value;
                perimetroTotal += PerimetroFiguras[figura.Key];
                areaTotal += AreaFiguras[figura.Key];
            }

            sb.Append(cantidadTotal + " " + frases["Formas"] + " ");
            sb.Append(frases["Perimetro"] + " " + perimetroTotal.ToString("#.##") + " ");
            sb.Append(frases["Area"] + " " + areaTotal.ToString("#.##"));
        }

        private string Pluralizador(string figura, int cantidad)
        {
            if (cantidad > 1)
            {
                return frases[figura+"P"];
            }
            else
            {
                return frases[figura+"S"];
            }
        }
    }

}
