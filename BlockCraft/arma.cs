using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCraft
{
    internal class arma
    {
        private String nombre;
        private int daño;

        public arma (String nombre, int daño)
        {
            this.nombre = nombre;
            this.daño = daño;
        }

        public int getDanio()
        {
            return this.daño;
        }


    }
}
