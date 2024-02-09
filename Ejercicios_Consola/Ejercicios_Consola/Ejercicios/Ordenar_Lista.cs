using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class Ordenar_Lista
    {
        public void Ordenar()
        {
            string[] Lista_Numeros;
            int[] Lista_asc;
            int[] Lista_des;

            string numeros;
            char delimitador = ',';
            int selec = 1;

            while (selec != 0)
            {
                Console.WriteLine("Ingrese lista de numeros separados por coma:");
                numeros = Console.ReadLine();

                //ASIGNO LISTADO DE NUMEROS A LOS ARRAY LISTA_ASC Y LISTA_DESC 
                Lista_Numeros = numeros.Split(delimitador);
                Lista_asc = new int[Lista_Numeros.Length];
                Lista_des = new int[Lista_Numeros.Length];

                for (int k = 0; k < Lista_Numeros.Length; k++)
                {
                    Lista_asc[k] = int.Parse(Lista_Numeros[k]);
                    Lista_des[k] = int.Parse(Lista_Numeros[k]);
                }

                //ORDENO LOS NUMERO ASCENDENTEMENTE
                for (int i = 0; i < Lista_asc.Length; i++)
                {
                    for (int j = 0; j < Lista_asc.Length - 1; j++)
                    {
                        if (Lista_asc[j] > Lista_asc[j + 1])
                        {
                            int valor;
                            valor = Lista_asc[j];
                            Lista_asc[j] = Lista_asc[j + 1];
                            Lista_asc[j + 1] = valor;
                        }
                    }
                }

                foreach (int n in Lista_asc)
                {
                    Console.Write("{0} ", n);
                }
                Console.WriteLine("\n");

                //ORDENO LOS NUMERO DESCENDENTEMENTE
                for (int k = 0; k < Lista_des.Length-1; k++)
                {
                    for (int h = 0; h < Lista_des.Length - 1; h++)
                    {
                        if (Lista_des[h] < Lista_des[h + 1])
                        {
                            int aux;
                            aux = Lista_des[h];
                            Lista_des[h] = Lista_des[h + 1];
                            Lista_des[h + 1] = aux;
                        }
                    }
                }

                foreach (int m in Lista_des)
                {
                    Console.Write("{0} ", m);
                }
                Console.WriteLine("\n");

                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea ordenar otros numeros");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
            }



            //Array.Sort(Lista_Numeros);

            //Lista_Reverse = numeros.Split(delimitador);
            //Array.Sort(Lista_Reverse);
            //Array.Reverse(Lista_Reverse);

            //foreach (string num in Lista_Numeros)
            //{
            //    Console.WriteLine(num.Trim());
            //}

            //Console.WriteLine("\n");
            //Console.WriteLine(string.Join(", ", Lista_Reverse));

        }
    }
}
