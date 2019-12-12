using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingChallenge.Data.Classes
{
    public abstract class Idioma
    {
        private Dictionary<string, string> FrasesArray = new Dictionary<string, string>();

        public void SetFrasesArray(Dictionary<string, string> FrasesArray) 
        {
            this.FrasesArray = FrasesArray;
        }

        public Dictionary<string, string> GetFrasesArray() 
        {
            return FrasesArray;
        }

        public string TipoIdioma { get; set; }

    }
}
