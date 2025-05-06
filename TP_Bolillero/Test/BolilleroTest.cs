using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TP_Bolillero
{
    public class BolilleroTest
    {
        private Bolillero bolillero;

        public BolilleroTest()
        {
            Bolillero = new Bolillero(10);
            Bolillero.SetAzar(new Primero());
        }

        [Fact]
        public void SacarBolilla()
        {
            int bolilla = Bolillero.SacarBolilla();
            Assert.Equal(0, bolilla);
            Assert.Equal(0, Bolillero.CantidadDentro());
            Assert.Equal(0, Bolillero.CantidadFuera());
        }

        [Fact]
        public void ReIngresar()
        {
            bolillero.SacarBolilla();
            bolillero.ReIngresar();
            Assert.Equal(10, bolillero.CantidadDentro());
            Assert.Equal(0, bolillero.CantidadFuera());
        }

        [Fact]
        public void JugarGana()
        {
            var jugada = new List<int> { 0, 1, 2, 3 };
            bool gano = bolillero.Jugar(jugada);
            Assert.True(gano);
        }

        [Fact]
        public void JugarPierde()
        {
            var jugada = new List<int> { 4, 2, 1 };
            bool gano = bolillero.Jugar(jugada);
            Assert.False(gano);
        }

        [Fact]
        public void GanarNVeces()
        {
            var jugada = new List<int> { 0, 1 };
            int ganadas = bolillero.JugarNVeces(jugada, 1);
            Assert.Equal(1, ganadas);
        }
    }
}