using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_Bolillero
{
    public class RandomAzar : IAzar
    {
        private Random random = new Random();

        public int Proximo(int Maximo)
        {
            return random.Next(Maximo);
        }
    }
}