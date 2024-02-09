using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class No_Primo
    {
        public void Numero_Primo()
        {
            
            int numero;
            int Primo=0;
            int selec = 1;

            while(selec != 0)
            {
                Console.WriteLine("Ingrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                for (int i = 1; i <= numero; i++)
                {
                    if (numero % i == 0)
                    {
                        Primo++;
                    }
                }

                if (Primo == 2)
                {
                    Console.WriteLine("{0}{1}",numero," Es un numero Primo");
                }
                else
                {
                    Console.WriteLine("{0}{1}", numero, " No es un numero Primo");
                }
                Console.WriteLine("\n");
                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea determinar otro numero: ");
                int.TryParse(Console.ReadLine(), out selec);
                Console.WriteLine("\n");
                if (selec == 0)
                    Console.Clear();
            }
        }
    }
}
