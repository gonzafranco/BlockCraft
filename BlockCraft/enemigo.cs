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
        private double vida;

        public enemigo(String nombre)
        {
            this.nombre = nombre;
            this.vida = 100.0;
        }



        public double getVida()
        {
            return this.vida;
        }

        public void calcularDanio(double danio)
        {
            this.vida -= danio;
        }

        public String status()
        {
            return this.vida <= 0 ? "Me mori!" : "Estoy vivo!";  
            
        }

    }
}
