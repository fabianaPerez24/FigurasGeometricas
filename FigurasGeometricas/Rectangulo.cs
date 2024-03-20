using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class Rectangulo
    {
        float variable1;
        float variable2;

        public Rectangulo(float variable1, float variable2)
        {
            this.variable1 = variable1;
            this.variable2 = variable2;
        }

        public float Area()
        {
            return variable1 * variable2;
        }

        public float Perimetro()
        {
            return (variable1*2)+ (variable2*2);
        }
    }
}
