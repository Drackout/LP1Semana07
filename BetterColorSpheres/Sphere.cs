using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BetterColorSpheres
{
    public class Sphere
    {
        public Color Cor  {get;}
        private float raio;
        private int atirado;
        
        public Sphere(Color cor, int raio, int atirado = 0)
        {
            Cor = cor;
            this.raio = raio;
        }

        public void Pop()
        {
            raio = 0;
        }
        
        public void Throw()
        {
            if (raio > 0)
                atirado++;
        }

        public float GetRadius
        {
            get => raio;
        }
        
        public int GetTimesThrown
        {
            get => atirado;
        }
        
        public string GetColor
        {
            get => Cor.GetColor;
        }
    }
}