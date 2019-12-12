using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class FiguraGeometrica 
    { 

        private double[] lados;
        private double[] bases;

        public void SetLados(double[] lados)
        {
            this.lados = lados;
        }

        public double[] GetLados()
        {
            return lados;
        }

        public void SetBases(double[] bases) 
        {
            this.bases = bases;
        }

        public double[] GetBases() 
        {
            return bases;
        }

        public string Tipo { get; set; }
        public double Altura { get; set; }
        public double Radio { get; set; }
    }   
}
