using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class Contar_Voc_Con
    {
        public void Contar()
        {
            string texto;
            int vocales=0;
            int consonantes = 0;
            int letra;
            int selec=1;

            while (selec != 0)
            {
                Console.WriteLine("Ingrese texto: ");
                texto = Console.ReadLine();
                texto = texto.Replace(" ", "");

                for (int i = 0; i < texto.Length; i++)
                {
                    letra = texto[i];

                    if ((letra == 'a' || letra == 'A') || (letra == 'e' || letra == 'E') || (letra == 'i' || letra == 'I') || (letra == 'o' || letra == 'O') || (letra == 'u' || letra == 'U'))
                    {
                        vocales++;
                    }
                    else
                    {
                        consonantes++;
                    }
                }
                Console.WriteLine("Cantidad de Vocales: {0}",vocales);
                Console.WriteLine("Cantidad de Consonantes: {0}",consonantes);
                vocales = 0;
                consonantes = 0;

                Console.WriteLine("\n");
                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea Contar otro texto");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
            }

        }
    }
}
