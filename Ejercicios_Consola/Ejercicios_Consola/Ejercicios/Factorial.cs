using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class Factorial
    {
        public void Calcular_Factorial()
        {
            int Numero;
            int factorial=1;
            int selec = 1;

            while (selec != 0)
            {
                Console.WriteLine("Ingrese un numero entero positivo: ");
                Numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= Numero; i++)
                {
                    factorial = i * factorial;
                }
                Console.WriteLine("El factorial es: {0}", factorial);

                Console.WriteLine("\n");
                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea Calcular otro Factorial");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
            }

        }
    }
}
