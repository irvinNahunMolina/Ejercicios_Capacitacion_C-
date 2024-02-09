using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicios_Consola.Ejercicios
{
    class Ahorcado
    {
        public void Juego_Ahorcado()
        {
            const string Archivo_Palabras = "palabras.txt";
            string PalabraAdivinar;
            string PalabraMostrar = "";
            int IndiceAzar;

            string SiguienteMostrar = "";
            int MaxIntentos = 0;
            int IntentoFallido = 0;
            int FallosRestantes = 3;
            char LetraActual;
            bool Terminado = false;
            int selec = 1;

            while (selec != 0)
            {
                string[] Palabras = File.ReadAllLines(Archivo_Palabras);
                Random rnd = new Random();

                //Obtengo palabra al azar
                IndiceAzar = rnd.Next(0, Palabras.Length);
                PalabraAdivinar = Palabras[IndiceAzar];

                //Mostrar la pabra en guiones agregar espacio si contiene espacios(--- ----)
                for (int i = 0; i < PalabraAdivinar.Length; i++)
                    if (PalabraAdivinar[i] == ' ')
                        PalabraMostrar += " ";
                    else
                        PalabraMostrar += "-";

                MaxIntentos = FallosRestantes;
                do
                {          
                    Console.WriteLine("Maximo Intentos:  {0}", MaxIntentos);
                    Console.WriteLine("Palabra oculta:  {0}", PalabraMostrar);
                    Console.WriteLine("Intentos Fallidos:  {0}", IntentoFallido);
                    Console.WriteLine("Fallos restantes: {0}", FallosRestantes);

                    Console.Write("Introduzca una letra: ");
                    LetraActual = Convert.ToChar(Console.ReadLine());

                    if (PalabraAdivinar.IndexOf(LetraActual) == -1)
                        FallosRestantes--;

                    if (PalabraAdivinar.IndexOf(LetraActual) == -1)
                        IntentoFallido++;

                    SiguienteMostrar = "";
                    for (int i = 0; i < PalabraAdivinar.Length; i++)
                    {
                        if (LetraActual == PalabraAdivinar[i])
                        {
                            SiguienteMostrar += LetraActual;
                        }                            
                        else
                        {
                            SiguienteMostrar += PalabraMostrar[i];                            
                        }          
                    }
                    PalabraMostrar = SiguienteMostrar;

                    if (PalabraMostrar.IndexOf("-") < 0)
                    {
                        Console.WriteLine("Felicidades, acertaste!  ({0})", PalabraAdivinar);
                        Terminado = true;
                    }

                    if (FallosRestantes == 0)
                    {
                        Console.WriteLine("Lo siento, la palabra Era: {0}", PalabraAdivinar);
                        Terminado = true;
                    }

                    Console.WriteLine();

                }
                while (!Terminado);

                PalabraAdivinar = "";
                PalabraMostrar = "";
                IndiceAzar = 0;
                SiguienteMostrar = "";
                MaxIntentos = 0;
                FallosRestantes = 3;
                Terminado = false;

                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea Jugar de una vez mas");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
            }
           
        }
    }
}
