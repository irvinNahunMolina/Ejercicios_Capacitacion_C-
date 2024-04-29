using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tablas_Matriz
{
    class Program
    {
        static void Main(string[] args)
        {
            int Inicio_Multiplicando;
            int Final_Multiplicando;
            int Multiplicador;
            int [,] Producto;
            int Cant_Tablas;
            int filaActual=0;

            Console.WriteLine("Ingrese inicio de la tabla de multiplicar:");
            Inicio_Multiplicando = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese final de la tabla de Multiplicar");
            Final_Multiplicando = int.Parse(Console.ReadLine());

            Console.WriteLine("Ingrese numero hasta donde debe llegar la tabla:");
            Multiplicador = int.Parse(Console.ReadLine());


            Cant_Tablas = Math.Abs(Inicio_Multiplicando - Final_Multiplicando) + 1;            
            Producto = new int[Cant_Tablas * Multiplicador, 3];
            
            for (int X = Inicio_Multiplicando; X <= Final_Multiplicando; X++)
            {
                for (int J = 1;J <= Multiplicador;J++)
                {
                    Producto[filaActual,0] = X;
                    Producto[filaActual,1] = J;
                    Producto[filaActual,2] = X * J;
                    filaActual++;
                }                
            }
            
            for(int V=0; V<Multiplicador;V++)
            {
                for(int L=0; L < Cant_Tablas; L++)
                {
                    Console.Write("{0}*{1}={2}\t",Producto[V+L*Multiplicador,0].ToString(),Producto[V+L*Multiplicador,1].ToString(),Producto[V+L*Multiplicador,2].ToString());
                }
                Console.WriteLine();
            }
            Console.ReadKey();

        }
    }
}
