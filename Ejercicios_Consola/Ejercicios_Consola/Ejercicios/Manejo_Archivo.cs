using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Ejercicios_Consola.Ejercicios
{
    class Manejo_Archivo
    {
        public void Leer_Archivo() 
        {
            StreamReader Archivo = File.OpenText("C:/Users/IT/OneDrive - PLASTINOVA INDUSTRIAL S.A . DE C.V/Escritorio/C#/Ejercicios_Consola/Reporte_Olvin_Sacos.txt");
            string Linea;
            int Can_Palabs = 0;
            int Contar_Line = 0;

            Console.WriteLine("Nombre del Archivo: {0}","Reporte_Olvin_Sacos");

            Console.WriteLine("Contenido del archivo: ");
            while ((Linea = Archivo.ReadLine()) != null)
            {
                Console.WriteLine("{0} {1}",++Contar_Line,Linea);
            }

            Console.WriteLine(Archivo.ReadToEnd());
            Archivo.Close();
            //////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("RESUMEN: ");
            Archivo = File.OpenText("C:/Users/IT/OneDrive - PLASTINOVA INDUSTRIAL S.A . DE C.V/Escritorio/C#/Ejercicios_Consola/Reporte_Olvin_Sacos.txt");
            do
            {
                Linea = Archivo.ReadLine();
                if (Linea != null)
                {
                    string[] words = Linea.Split(' ');
                    Can_Palabs += words.Length;
                }
            }
            while (Linea != null);
            Archivo.Close();
            Console.WriteLine("Cantidad Palabras: " + Can_Palabs);
      /////////////////////////////////////////////////////////////////////////

            string line;
            int Cant_Letras_Space = 0;
            int Cant_Letras = 0;

            Archivo = File.OpenText("C:/Users/IT/OneDrive - PLASTINOVA INDUSTRIAL S.A . DE C.V/Escritorio/C#/Ejercicios_Consola/Reporte_Olvin_Sacos.txt");
            do
            {
                line = Archivo.ReadLine();                
                if (line != null)
                {
                    Cant_Letras_Space += line.Length;
                    line = line.Replace(" ", "");
                //for (int i = 0; i < line.Length; i++)                
                    Cant_Letras += line.Length;
                }

            }while (line != null);
            Archivo.Close();
            Console.WriteLine("Cantidad Caracteres con espacios: {0}", Cant_Letras_Space);
            Console.WriteLine("Cantidad Caracteres: {0}", Cant_Letras);
            ///////////////////////////////////////////////////////////////////////////////////////////

            string linea;
            int count = 0;

            Archivo = File.OpenText("C:/Users/IT/OneDrive - PLASTINOVA INDUSTRIAL S.A . DE C.V/Escritorio/C#/Ejercicios_Consola/Reporte_Olvin_Sacos.txt");
            do
            {
                linea = Archivo.ReadLine();
                if (linea != null)
                {
                    for (int i = 0; i < linea.Length; i++)
                    {
                        // Comprobamos que no sea un espacio
                        if (char.IsWhiteSpace(linea[i]))
                        {
                            count++;
                        }
                    }
                }

            } while (linea != null);
            Archivo.Close();
            Console.WriteLine("Cantidad de espacios: {0}", count);
            /////////////////////////////////////////////////////////////////////////////

            string lineas;
            int Contar = 0;
            Archivo = File.OpenText("C:/Users/IT/OneDrive - PLASTINOVA INDUSTRIAL S.A . DE C.V/Escritorio/C#/Ejercicios_Consola/Reporte_Olvin_Sacos.txt");

            while ((lineas = Archivo.ReadLine()) != null)
            {
                Contar++;
            }
            Console.WriteLine("Cantidad de lineas: {0}", Contar);
            Console.WriteLine("\n");
        }
    }
}
