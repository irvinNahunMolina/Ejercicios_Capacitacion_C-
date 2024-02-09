using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class Conversion_Unidades
    {
        public void Conversion()
        {
            string[] Unidades = { "1-.Libras", "2-.Kilogramos", "3-.Gramos", "4-.Onzas", "5-.Toneladas", 
                                    "6-.Minutos", "7-.Segundos", "8-.Dias ", "9-.Horas", "10-.Milisegundo", 
                                "11-.Galones", "12-.Metros Cubicos", "13-.Litros", "14-.Mililitros", "15-.Centimetros Cubicos" };

            double[][] Conversion = { new double[]{ 1, 1, 1 }, new double[] { 1, 2, 2.20462 }, new double[]{ 1, 3, 0.00220462 }, new double[]{ 1, 4, 0.0625 }, new double[]{ 1, 5, 2204.62 }, 
                                        new double[]{ 2, 6, 1 }, new double[]{ 2, 7, 0.0166666 }, new double[]{ 2, 8, 1440 }, new double[]{ 2, 9, 60 }, new double[]{ 2, 10, 0.00001666666 }, 
                                    new double[]{ 3, 11, 1 }, new double[]{ 3, 12, 264.172 }, new double[]{ 3, 13, 0.264172 }, new double[]{ 3, 14, 0.000264172 }, new double[]{ 3, 15, 0.000264172 } };
           
            double Valor;
            int Uni_Medida_Or;
            int Uni_Medida_Des;
            double Cate_Selec;
            int selec = 1;

            while (selec != 0)
            {
                Console.WriteLine("Unidades de Conversion: ");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("{0}\t{1}\t{2}", Unidades[i], Unidades[i + 5], Unidades[i + 10]);
                }

                Console.WriteLine("\n");
                Console.WriteLine("Ingrese valor a convertir: ");
                Valor = double.Parse(Console.ReadLine());

                Console.WriteLine("Ingrese Unidad de Medida (Origen): ");
                Uni_Medida_Or = int.Parse(Console.ReadLine());

                Cate_Selec = Conversion[Uni_Medida_Or - 1][0];

                Console.WriteLine("\n");
                for (int j = 0; j < 15; j++)
                {
                    if (Conversion[j][0] == Cate_Selec)
                    {
                        Console.WriteLine(Unidades[j]);
                    }
                }

                Console.WriteLine("Ingrese Unidad de Medida (Destino): ");
                Uni_Medida_Des = int.Parse(Console.ReadLine());

                Console.WriteLine("\n");
                Console.WriteLine("{0}{1}{2}{3}{4}{5}{6}{7}", Valor, " ", Unidades[Uni_Medida_Or - 1].Substring(3), " ", "Equivalen a: ",
                                    (Valor * Conversion[Uni_Medida_Or - 1][2] / Conversion[Uni_Medida_Des - 1][2]), " ", Unidades[Uni_Medida_Des - 1].Substring(3)); ;
                Console.WriteLine("\n");
                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea realizar otra conversion");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
            }
        }        
    }
}
