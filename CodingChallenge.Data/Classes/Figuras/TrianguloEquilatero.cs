using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrianguloEquilatero : FiguraGeometrica, OperacionesFiguras
    {
        public TrianguloEquilatero()
        {
            this.Tipo = "Triangulo";
        }

        public double GetArea()
        {
            return Math.Round(((double)Math.Sqrt(3) / 4) * Math.Pow((this.GetLados()[0]),2),2);
        }

        public double GetPerimetro()
        {
            return Math.Round(((double) this.GetLados()[0] * 3),2);
        }
    }
}
