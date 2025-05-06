using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_Bolillero
{
    public class Bolillero
    {
        private List<int> dentro;
        private List<int> fuera;
        private IAzar azar;

        public Bolillero(int cantidadBolillas)
        {
            dentro = Enumerable.Range(0, cantidadBolillas).ToList();
            fuera = new List<int>();
        }

        public void SetAzar(IAzar azar)
        {
            this.azar = azar;
        }

        public int SacarBolilla()
        {
            int indice = azar.Proximo(dentro.Count);
            int bolilla = dentro[indice];
            dentro.RemoveAt(indice);
            fuera.Add(bolilla);
            return bolilla;
        }

        public void ReIngresar()
        {
            dentro.AddRange(fuera);
            fuera.Clear();
        }

        public bool Jugar(List<int> jugada)
        {
            foreach (int esperada in jugada)
            {
                if (SacarBolilla() != esperada)
                {
                    return false;
                }
            }
            return true;
        }

        public int JugarNVeces(List<int> jugada, int cantidad)
        {
            int ganadas = 0;
            for (int i = 0; i < cantidad; i++)
            {
                ReIngresar();
                if (Jugar(jugada))
                {
                    ganadas++;
                }
                ReIngresar();
            }
            return ganadas;
        }

        public int CantidadDentro() => dentro.Count;
        public int CantidadFuera() => fuera.Count;
    }
}