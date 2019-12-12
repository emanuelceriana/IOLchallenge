using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Circulo : FiguraGeometrica, OperacionesFiguras
    {
        public Circulo()
        {
            this.Tipo = "Circulo";
        }
        public double GetArea()
        {
            return Math.Round((Math.PI * Math.Pow(this.Radio,2)),2);
        }

        public double GetPerimetro()
        {
            return Math.Round((2 * Math.PI * this.Radio),2);
        }
    }
}
