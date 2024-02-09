using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class Tabla_Multiplicar
    {
        public void Tabla_Mult()
        {
            int num_ini=0;
            int num_fin = 0;
            int selec = 1;

            while(selec!=0)
            {
                Console.WriteLine("Ingrese numero para generar tabla muultiplicar:");
                num_ini = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese Limite de la tabla");
                num_fin = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");

                for (int i = 0; i <= num_fin; i++)
                {
                    Console.WriteLine(num_ini + "*" + i + "=" + num_ini * i);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea generar otra tabla de multiplicar");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
                //Console.WriteLine("\n");
            }          
        }
    }
}
