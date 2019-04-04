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
            if (posicionfinal == 0)
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
