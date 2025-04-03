using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        private Color Cor  {get;}
        private float Raio;
        private int Atirado;
        
        public Sphere(Color cor, int raio, int atirado = 0)
        {
            Cor = cor;
            Raio = raio;
        }

        public void Pop()
        {
            set
            {
                Raio = 0;
            }
        }
    }
}