using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public class TrapecioRectangulo : FiguraGeometrica, OperacionesFiguras
    {
        public TrapecioRectangulo()
        {
            this.Tipo = "Trapecio";
        }

        public double GetArea()
        {
            return Math.Round((this.Altura * (this.GetBases()[0] + this.GetBases()[1]) / 2),2);
        }

        public double GetPerimetro()
        {
            return Math.Round((this.GetLados()[0] + this.GetLados()[1] + this.GetLados()[2] + this.GetLados()[3]),2);
        }
    }
}
