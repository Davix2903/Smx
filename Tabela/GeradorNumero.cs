using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smx
{
    public class GeradorNumero
    {
        private Random propriedadeNumeroAleatorio => new Random();

        public int MetodoNumeroAleatorio()
        {
            var retorno = propriedadeNumeroAleatorio.Next(1, 9);
            switch (retorno)
            {
                case 1:
                case 2:
                case 9:
                    retorno = 0;
                    break;

                case 3:
                case 5:
                case 6:
                    retorno = 1;
                    break;

                case 4:
                case 7:
                case 8:
                    retorno = 2;
                    break;

            }
            return retorno;
        }
    }

}
