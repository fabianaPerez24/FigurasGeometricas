using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class Triangulo
    {
        float variable3;
        float variable4;

        public Triangulo(float variable3, float variable4)
        {
            this.variable3 = variable3;
            this.variable4 = variable4;
        }

        public float Area()
        {
            return variable3 * variable4/2;
        }

    }
}
