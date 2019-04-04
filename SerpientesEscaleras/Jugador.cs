using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesEscaleras
{
    class Jugador
    {
        private int _posicion;
        
        public Jugador()
        {
            _posicion = 0;
            
        }

        public int Posicion
        {
            get { return _posicion; }
        }

        public void Mover(int distancia)
        {
            _posicion += distancia;
        }
    }
}
