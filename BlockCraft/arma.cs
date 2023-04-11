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
        private double danio;

        public arma (String nombre, double danio)
        {
            this.nombre = nombre;
            this.danio = danio;
        }

        public double getDanio()
        {
            return this.danio;
        }


    }
}
