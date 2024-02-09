using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class Fibonacci
    {
        public void Secu_Fibonacci()
        {
            int Secu_Progre=0;
            int Secu_Progre2 = 1;
            int Cant_Elementos;
            string numero = " ";
            int selec = 1;

            while(selec != 0)
            {
                Console.WriteLine("Ingrese cantidad de terminos de la secuencia: ");
                Cant_Elementos = int.Parse(Console.ReadLine());

                //Console.WriteLine(Secu_Progre);
                Cant_Elementos = Cant_Elementos - 2;

                for (int i = 0; i <= Cant_Elementos; i++)
                {
                    int Temp = Secu_Progre;
                    Secu_Progre = Secu_Progre2;

                    Secu_Progre2 = Temp + Secu_Progre;
                    numero += Secu_Progre + ", ";
                }
                Console.WriteLine("0,{0}", numero);
                numero = " ";
                Secu_Progre = 0;
                Secu_Progre2 = 1;

                Console.WriteLine("\n");
                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea Calcular otra Secuencia Fibonacci");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
            }

        }
    }
}
