using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola
{
    class Calculadora_Simple
    {
        public void Calcular()
        {
            Calculadora_Simple obj = new Calculadora_Simple();
            int selec;
            Double num1, num2;

            Console.WriteLine("Digite dos numero y seleccione la operacion que desea realizar: ");
            Console.WriteLine("\n");

            Console.WriteLine("Digite el primer numero: ");
            num1 = Double.Parse(Console.ReadLine());
            Console.WriteLine("Digite el segundo numero: ");
            num2 = Double.Parse(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Seleccione la operacion a realizar: ");
            Console.WriteLine("0-.Salir, 1-.suma, 2-.resta, 3-.multiplicacion, 4-.division ");
            int.TryParse(Console.ReadLine(), out selec);
            Console.WriteLine("\n");

            while (selec != 0)
            {
                if (selec == 1)
                {
                    Console.WriteLine("su respuesta es: {0}", obj.suma(num1, num2));
                    Console.WriteLine("\n");
                }
                else if (selec == 2)
                {
                    Console.WriteLine("su respuesta es: {0}", obj.resta(num1, num2));
                    Console.WriteLine("\n");
                }
                else if (selec == 3)
                {
                    Console.WriteLine("su respuesta es: {0}", obj.multiplicacion(num1, num2));
                    Console.WriteLine("\n");
                }
                else if (selec == 4)
                {
                    obj.division(num1, num2);
                    Console.WriteLine("\n");
                }

                Console.WriteLine("Si desea salir marque 0 si desea continuar marque una operacion");
                Console.WriteLine("0-.Salir, 1-.suma, 2-.resta, 3-.multiplicacion, 4-.division ");
                int.TryParse(Console.ReadLine(), out selec);
                Console.WriteLine("\n");
                if (selec == 0)
                {
                    Console.Clear();
                    break;
                }                    
                Console.WriteLine("Digite el primer numero: ");
                num1 = Double.Parse(Console.ReadLine());
                Console.WriteLine("Digite el segundo numero: ");
                num2 = Double.Parse(Console.ReadLine());
                Console.WriteLine("\n");
                //Console.ReadKey();
            }
        }

        Double suma(Double numero1, Double numero2)
        {
            Double res;

            res = numero1 + numero2;

            return res;
        }

        Double resta(Double numero1, Double numero2)
        {
            Double res;

            res = numero1 - numero2;

            return res;
        }

        Double multiplicacion(Double numero1, Double numero2)
        {
            Double res;

            res = numero1 * numero2;

            return res;
        }

        void division(Double numero1,Double numero2)
        {
            Double res;

            if(numero2 != 0)
            {
                res = numero1 / numero2;
                Console.WriteLine("Su respuesta es: {0}", res);
            }
            else
            {
                Console.WriteLine("No Se Puede Dividir Entre Cero");
            }
        }
    }

}
