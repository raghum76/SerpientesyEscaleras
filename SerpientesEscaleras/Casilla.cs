using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesEscaleras
{
    class Casilla
    {
        private int posicioninicial;
        private int posicionfinal = 0;

        public Casilla(int inicial)
        {
            posicioninicial = inicial;
        }
        public Casilla(int inicial,int final)
        {
            posicioninicial = inicial;
            posicionfinal = final;
        }

        public bool esEscaleraoSerpiente()
        {
            if (posicionfinal == posicioninicial) //en lugar de comparar con 0, deberías checar si inicia y termina donde mismo
            {
                return false;
            }
            else
                return true;
        }

        public void EnviarA()
        {

        }
    }
}
