using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class Rectangulo : FiguraGeometrica, OperacionesFiguras
    {
        public Rectangulo()
        {
            this.Tipo = "Rectangulo";
        }
        public double GetArea()
        {
            return Math.Round(this.GetBases()[0] * this.Altura);
        }

        public double GetPerimetro()
        {
            return Math.Round((2 * this.GetBases()[0]) + (2 * this.Altura));
        }
    }
}
