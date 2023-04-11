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
        private double daño;

        public arma (String nombre, double daño)
        {
            this.nombre = nombre;
            this.daño = daño;
        }

        public double getDanio()
        {
            return this.daño;
        }


    }
}
