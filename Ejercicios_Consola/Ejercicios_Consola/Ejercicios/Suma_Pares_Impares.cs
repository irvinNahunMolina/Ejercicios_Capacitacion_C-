using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class Suma_Pares_Impares
    {
        public void Num_Pares_Impa()
        {
            string numeros;
            char delimitador = ',';
            string[] lista_numeros;
            string Pares=" ";
            string Impares = " ";
            int Num_Par;
            int Num_Impar;
            int Sum_Par=0;
            int Sum_Impar=0;
            int List_Num;
            int selec=1;

            while (selec!=0)
            {
                Console.WriteLine("Ingrese lista de numeros separados por coma:");
                numeros = Console.ReadLine();
                Console.WriteLine("\n");

                lista_numeros = numeros.Split(delimitador);

                foreach (string num in lista_numeros)
                {
                    Console.WriteLine(num.Trim());
                }

                foreach (string num in lista_numeros)
                {
                    List_Num = Int32.Parse(num.Trim());
                    if (List_Num % 2 == 0)
                    {
                        Num_Par = List_Num;
                        Pares += num + ", ";
                        Sum_Par = Sum_Par + Num_Par;
                    }
                    else
                    {
                        Num_Impar = List_Num;
                        Impares += num + ", ";
                        Sum_Impar = Sum_Impar + Num_Impar;
                    }
                }
                Console.WriteLine("\n");
                Console.WriteLine("Numeros Pares {0}", Pares);
                Console.WriteLine("Numeros Impares {0}", Impares);
                Console.WriteLine("la suma de numeros pares es: {0}", Sum_Par);
                Console.WriteLine("la suma de numeros impares es: {0}", Sum_Impar);
                Sum_Par = 0;
                Sum_Impar = 0;
                Pares = " ";
                Impares = " ";

                Console.WriteLine("\n");
                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea listar otros numeros");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
            }

        }
    }
}
