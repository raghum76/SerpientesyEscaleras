using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerpientesEscaleras
{
    ///clase dado
    class Dado
    {
        private Random Random = new Random();


        public int Lanzar()
        {
            return Random.Next(1, 7);
        }
    }
}
