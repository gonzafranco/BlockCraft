using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlockCraft
{
    internal class enemigo
    {
        private String nombre;
        private int vida;

        public enemigo(String nombre)
        {
            this.nombre = nombre;
            this.vida = 100;
        }

        public int getVida()
        {
            return this.vida;
        }

        public void calcularDanio(int danio)
        {
            this.vida -= danio;
        }
    }
}
