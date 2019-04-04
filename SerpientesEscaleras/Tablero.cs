using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesEscaleras
{
    class Tablero
    {
        private Casilla[] tab = new Casilla[100];

        public Tablero()
        {
            for (int i = 0; i <= tab.Length -1; i++)
            {
                tab[i] = new Casilla(i);
            }
            tab[04] = new Casilla(04, 25);
            tab[13] = new Casilla(13, 46);
            tab[33] = new Casilla(33, 49);
            tab[42] = new Casilla(42, 63);
            tab[50] = new Casilla(50, 69);
            tab[62] = new Casilla(62, 81);
            tab[74] = new Casilla(74, 92);
            tab[82] = new Casilla(82, 98);

            tab[27] = new Casilla(27, 05);
            tab[40] = new Casilla(40, 03);
            tab[43] = new Casilla(43, 18);
            tab[54] = new Casilla(54, 31);
            tab[66] = new Casilla(66, 45);
            tab[76] = new Casilla(76, 58);
            tab[89] = new Casilla(89, 53);
            tab[99] = new Casilla(99, 41);
        }

        public Casilla Casilla(int posicion)
        {
            return tab[posicion];
        }

        public int Mover(int posicion)
        {
            return tab[posicion];
        }
    }
}
