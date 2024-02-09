using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicios_Consola.Ejercicios
{
    class Amortizacion_Prestamo
    {
        public void Amortizacion()
        {
            double Valor_Prest;
            double Tasa;
            int Tiempo;
            double Interes_Pagado;
            double Interes_Acumulado=0;
            double Capital_Pagado;
            const int Tasa_Mes = 12;
            int selec = 1;

            double Cuota;
            double Tasa_Mensual;
            double Valor;
            int Fila = 1;

            while (selec != 0)
            {
                Console.Write("Ingrese Valor del prestamo: ");
                Valor_Prest = double.Parse(Console.ReadLine());

                Console.Write("Ingrese tasa de interes anual: ");
                Tasa = double.Parse(Console.ReadLine());

                Console.Write("Ingrese Meses de pago a pagar el prestamo: ");
                Tiempo = int.Parse(Console.ReadLine());

                Tasa_Mensual = (Tasa / Tasa_Mes) / 100;
                Valor = Valor_Prest;
                Cuota = Valor_Prest / ((1 - Math.Pow((1 + Tasa_Mensual), (Tiempo * (-1)))) / Tasa_Mensual);

                Console.WriteLine();
                Console.WriteLine("Cuota Mensual: {0} ", Cuota.ToString("N2"));

                Console.WriteLine();
                Console.WriteLine();
                Console.Write(" Numero de pago \t");
                Console.Write("Pago Mensual \t");
                Console.Write("Interes Pagado \t\t");
                Console.Write("Abono a Capital \t");
                Console.Write("Intereses Acumulados \t");
                Console.Write("Monto del prestamo \t");
                Console.WriteLine();
                Console.WriteLine();
                Console.Write("\t0");
                Console.WriteLine("\t\t\t\t\t\t\t\t\t\t\t\t\t\t{0}", Valor_Prest.ToString("N2").PadLeft(10));

                for (int i = 1; i <= Tiempo; i++)
                {
                    Console.Write("\t{0}\t\t", Fila);

                    Console.Write("{0}\t", Cuota.ToString("N2"));

                    Interes_Pagado = Valor_Prest * ((Tasa / 100) / Tasa_Mes);
                    Console.Write("{0}\t", Interes_Pagado.ToString("N2").PadLeft(10));

                    Capital_Pagado = Cuota - Interes_Pagado;
                    Console.Write("\t{0}\t\t", Capital_Pagado.ToString("N2").PadLeft(10));

                    Interes_Acumulado = Interes_Acumulado + Interes_Pagado;
                    Console.Write("{0}\t\t", Interes_Acumulado.ToString("N2").PadLeft(10));

                    Valor_Prest = Valor_Prest - Capital_Pagado;
                    Console.Write("\t{0}\t", Valor_Prest.ToString("N2").PadLeft(2));

                    Fila = Fila + 1;
                    Console.WriteLine();

                }
                Console.WriteLine("\n");
                Console.Write("--> Monto del prestamo: {0} \t\t\t", Valor.ToString("N2").PadLeft(10));
                Console.Write("--> Pago Mensual: {0} \t ", Cuota.ToString("N2").PadLeft(10));
                Console.WriteLine("\n");
                Console.Write("--> Total Intereses: {0} \t\t\t", Interes_Acumulado.ToString("N2").PadLeft(10));
                Console.Write("--> Total Pagos: {0} \t", Tiempo);

                Console.ReadLine();
                Console.WriteLine("\n");
                Console.WriteLine("Seleccione un opcion:");
                Console.WriteLine("0-.Salir, 1-.Desea realizar otra consulta");
                int.TryParse(Console.ReadLine(), out selec);
                if (selec == 0)
                    Console.Clear();
            }

        }
    }
}
