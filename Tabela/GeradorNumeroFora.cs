using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Smx
{
    class GeradorNumeroFora
    {
        private Random propriedadeNumeroAleatorio => new Random();

        public int MetodoNumeroAleatorioFora()
        {
            var retorno = propriedadeNumeroAleatorio.Next(1, 9);

            switch (retorno)
            {

                case 3:
                case 4:
                case 9:
                    retorno = 0;
                    break;

                case 1:
                case 5:
                case 7:
                    retorno = 1;
                    break;

                case 2:
                case 6:
                case 8:
                    retorno = 2;
                    break;
            }
            return retorno;
        }
    }
}