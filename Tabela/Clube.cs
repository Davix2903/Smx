using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smx
{
    public class Clube
    {
        public string Nome { get; set; }
        public int Gols { get; set; }

        public Clube(string nome, int gols)
        {
            Nome = nome;
            Gols = gols;
        }
        public Clube()
        {

        }
    }
}
