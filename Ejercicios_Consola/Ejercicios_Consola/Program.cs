using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ejercicios_Consola;
using Ejercicios_Consola.Ejercicios;


namespace Ejercicios_Consola
{
    class Program
    {

        static void Main(string[] args)
        {
            Calculadora_Simple obj_CS = new Calculadora_Simple();
            Tabla_Multiplicar obj_TM = new Tabla_Multiplicar();
            Suma_Pares_Impares objSm = new Suma_Pares_Impares();
            Factorial obj_FAC = new Factorial();
            Fibonacci obj_fibo = new Fibonacci();
            No_Primo obj_No_Primo = new No_Primo();
            Contar_Voc_Con obj_V_C = new Contar_Voc_Con();
            Conversion_Unidades obj_CU = new Conversion_Unidades();
            Ordenar_Lista obj_O_L = new Ordenar_Lista();
            Busqueda_Lista obj_B_L = new Busqueda_Lista();
            Validar_Contrasena obj_Va_Con = new Validar_Contrasena();
            Manejo_Archivo obj_Manejo_Arch = new Manejo_Archivo();
            Amortizacion_Prestamo obj_Amort = new Amortizacion_Prestamo();
            Ahorcado obj_Ahorcado = new Ahorcado();
 
            int selec;
            string[] Menu = { "0-.Salir", "1-.Calculadora Simple", "2-.Tabla Multiplicar", "3-.Pares y Impares", "4-.Factorial", "        5-.Fibonacci     ",
                                "6-.Numero Primo   ", "7-.Vocales Consonantes", "8-.Conversion Unids", "        9-.Ordenar Lista", "10-.Buscar en Lista",
                                "11.-Validar Contraseña", "12.-Manejo Archivos", "13.-Amortizacion", "14.-Ahorcado"};

            Console.WriteLine("Digite el numero de la operacion que desea realizar: ");
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("{0}\t\t{1}\t\t{2}", Menu[i], Menu[i + 5], Menu[i + 10]);
            }

            int.TryParse(Console.ReadLine(), out selec);
            Console.WriteLine("\n");

            while(selec != 0)
            {
                if (selec == 1)
                {
                    obj_CS.Calcular();
                }
                else if (selec == 2)
                {
                    obj_TM.Tabla_Mult();
                }
                else if (selec == 3)
                {
                    objSm.Num_Pares_Impa();
                }
                else if (selec == 4)
                {
                    obj_FAC.Calcular_Factorial();
                }
                else if (selec == 5)
                {
                    obj_fibo.Secu_Fibonacci();
                }
                else if(selec == 6)
                {
                    obj_No_Primo.Numero_Primo();
                }
                else if (selec == 7)
                {
                    obj_V_C.Contar();
                }
                else if (selec == 8)
                {
                    obj_CU.Conversion();
                }
                else if (selec == 9)
                {
                    obj_O_L.Ordenar();
                }
                else if (selec == 10)
                {
                    obj_B_L.Busqueda();
                }
                else if (selec == 11)
                {
                    obj_Va_Con.Contrasena();
                }
                else if (selec == 12)
                {
                    obj_Manejo_Arch.Leer_Archivo();
                }
                else if (selec == 13)
                {
                    obj_Amort.Amortizacion();
                }
                else if (selec == 14)
                {
                    obj_Ahorcado.Juego_Ahorcado();
                }
                Console.WriteLine("Si desea salir marque 0 si desea continuar digite el numero de una opcion: ");
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("{0}\t\t{1}\t\t{2}", Menu[i], Menu[i + 5], Menu[i + 10]);
                }
                int.TryParse(Console.ReadLine(), out selec);
                Console.WriteLine("\n");
            }            
        }


    }
}
