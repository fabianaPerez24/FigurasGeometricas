using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FigurasGeometricas
{
    internal class Figuras
    {
        public void Start()
        {
            figuras();
        }

        bool continueflag = true;
        public void figuras()
        {
            while (continueflag)
            {
                Console.WriteLine("Que figura deseas operar?");
                Console.WriteLine("RECTANGULO");
                Console.WriteLine("TRIANGULO");
                Console.WriteLine("CIRCULO");

                String options = Console.ReadLine();

                switch (options)
                {
                    case "RECTANGULO":
                        float variable1, variable2;

                        Console.WriteLine("Ingrese la primera variable");
                        variable1 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda variable");
                        variable2 = float.Parse(Console.ReadLine());
                        Rectangulo rectangulo = new Rectangulo(variable1,variable2);
                        Console.WriteLine($"El perimetro del rectangulo es {rectangulo.Perimetro()} y su area es {rectangulo.Area()}");

                        break;

                    case "TRIANGULO":
                        float variable3, variable4;

                        Console.WriteLine("Ingrese la primera variable");
                        variable3 = float.Parse(Console.ReadLine());
                        Console.WriteLine("Ingrese la segunda variable");
                        variable4 = float.Parse(Console.ReadLine());
                        Triangulo triangulo = new Triangulo(variable3, variable4);
                        Console.WriteLine($"El area del triangulo es {triangulo.Area()}");

                        break;

                    case "CIRCULO":
                        float radio;

                        Console.WriteLine("Ingrese el radio");
                        radio = float.Parse(Console.ReadLine());

                        Circulo circulo = new Circulo(radio);
                        Console.WriteLine($"El area del circulo es {circulo.Area()}");

                            break;
                }
                Console.WriteLine("Desea continuar? Escriba SI o NO");
                if (Console.ReadLine() == "NO")
                {
                continueflag = false;
                }
            }
            
        }

    }

}
