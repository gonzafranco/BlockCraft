using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCraft
{
    internal class personaje
    {
        private String nombre;
        private arma arma;


        public personaje(String nombre, arma arma)
        {
            this.nombre = nombre;
            this.arma = arma;
        }


        public int  atacar(enemigo e)
        {
            int calculo = e.getVida() - this.arma.getDanio();
            return (calculo);
        }

        public void cambiarArma(arma arma)
        {
            this.arma = arma;
        }
    }
}
