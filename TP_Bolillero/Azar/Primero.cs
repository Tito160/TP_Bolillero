using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace 
{
    public class Primero : IAzar
    {
        private int Siguiente = 0;

        public int Proximo(int Maximo)
        {
            return Siguiente++;
        }
    }
}