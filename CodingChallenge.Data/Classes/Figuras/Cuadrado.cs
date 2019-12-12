using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Cuadrado : FiguraGeometrica, OperacionesFiguras
    {
        public Cuadrado()
        {
            this.Tipo = "Cuadrado";
        }
        public double GetArea()
        {
            return Math.Round((Math.Pow(this.GetLados()[0],2)),2);
        }

        public double GetPerimetro()
        {
            return Math.Round((4 * this.GetLados()[0]),2);
        }
    }
}
