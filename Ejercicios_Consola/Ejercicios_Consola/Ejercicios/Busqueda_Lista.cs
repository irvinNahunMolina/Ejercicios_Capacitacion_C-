using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class Busqueda_Lista
    {
        public void Busqueda() 
        {
            int numero;
            int min = 1;
            int max = 100;
            int[] Lista_Numeros= new int[10];
            bool valor = false;
            int selec = 1;

            while (selec != 0)
            {
                Random rnd = new Random();

                Console.WriteLine("Ingrese un numero entre 1 y 100:");
                numero = int.Parse(Console.ReadLine());

                for (int i = 0; i < Lista_Numeros.Length; i++)
                {
                    Lista_Numeros[i] = (rnd.Next(min, max + 1));
                    Console.Write(" {0} ", Lista_Numeros[i]);
                }
                Console.WriteLine("\n");

                for (int j = 0; j < Lista_Numeros.Length; j++)
                {
                    if (numero == Lista_Numeros[j])
                    {
                        valor = true;
                        if (j == 0)
                        {
                            Console.Write("-");
                        }
                        else
                        {
                            Console.Write(Lista_Numeros[j - 1]);
                        }

                        Console.Write(", {0}, ", Lista_Numeros[j]);

                        if (Lista_Numeros.Length - 1 == j)
                        {
                            Console.WriteLine("-");
                        }
                        else
                        {
                            Console.WriteLine(Lista_Numeros[j + 1]);
                        }
                    }
                }
                if (valor == false)
                {
                    Console.WriteLine("Valor No Encontrado");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea Ingresar otro numero");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
            }

            //string texto;
            //for (int j = 0; j < Lista_Numeros.Length; j++)
            //{
            //    if (numero == Lista_Numeros[j])
            //    {
            //        texto = "-";
            //        if (j != 0)
            //        {
            //            texto = Lista_Numeros[j - 1].ToString();
            //        }
            //        Console.Write(texto);
            //        Console.Write(", {0}, ", Lista_Numeros[j]);

            //        texto = "-";
            //        if (Lista_Numeros.Length - 1 != j)
            //        {
            //            texto = Lista_Numeros[j + 1].ToString();  
            //        }
            //        Console.WriteLine(texto);
            //    }
            //}
        }
    }
}
