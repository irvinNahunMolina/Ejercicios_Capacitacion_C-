using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class Validar_Contrasena
    {
        public void Contrasena()
        {
            string Password;
            bool Mayuscula = false;
            bool Minuscula=false;            
            bool CaracEspecial = false;
            bool Numero = false;
            int selec = 1;

            while (selec != 0)
            {
                Console.WriteLine("Ingrese su Contraseña:");
                Password = Console.ReadLine();

                for (int i = 0; i < Password.Length; i++)
                {
                    if (Char.IsUpper(Password, i))
                    {
                        Mayuscula = true;
                    }
                    else if (Char.IsLower(Password, i))
                    {
                        Minuscula = true;
                    }
                    else if (Char.IsDigit(Password, i))
                    {
                        Numero = true;
                    }
                    else if (!Char.IsLetter(Password, i))
                    {
                        CaracEspecial = true;
                    }
                }

                if (Mayuscula == true && Minuscula == true && Numero == true && CaracEspecial == true && Password.Length >= 8)
                {
                    Console.WriteLine("{0}{1}{2}", "La Contraseña ", Password, " es valida");
                }
                else
                {
                    Console.WriteLine("{0}{1}{2}", "La Contraseña ", Password, " no es valida");
                }

                Console.WriteLine("\n");
                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea validar otra Contraseña");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
            }

        }
    }
}
