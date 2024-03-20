using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class Circulo
    {
        float radio;
        float pi = 3.14f;

        public Circulo(float radio)
        {
            this.radio = radio;
        }

        public float Area()
        {
            return pi*radio*radio;
        }
    }
}
