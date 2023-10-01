using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//UH, Wilton Benedict Castillo
//INFO-104 Programacion 2
//Prof. Alexander Benjamin Curling
//Tarea 2
//10/01/2023
namespace INFO_104_Tarea2_Algoritmo1_WiltonBenedict
{

    internal class Program
    {
        static int camisas = 0; static int precio = 0;
        static bool estado1 = true; static bool estado2 = true;

        static void Main(string[] args)
        {
            while (estado1) 
            {
                estado2 = true;
                Inicio();//Metodo que captura los valores necesarios para el calculo
                CalculoCamisa();//Metodo que calcula el descuento
                CalculoFin();//Metodo que reinicia el programa o lo termina

            }

        }
        public static void Inicio()
        {
                Console.WriteLine("--Algoritmo 1--");
                Console.WriteLine(" Tienda de venta de camisas ");
                Console.WriteLine("¡Bievenido/a a la tienda de camisas!");
                Console.WriteLine("¡Promociones disponibles!");
                Console.WriteLine("\t 2 a 5 camisas con 15%");
                Console.WriteLine("\t 5 o mas camisas con 20%");
                Console.WriteLine("Por favor ingrese la cantidad de camisas: ");
                camisas = int.Parse(Console.ReadLine());
                Console.WriteLine("Por favor ingrese la cantidad el precio de las camisas: ");
                precio = int.Parse(Console.ReadLine());
                //Estructura de control para decidir el descuento aplicado
            }
        
        public static void CalculoCamisa() 
        {
            if (camisas == 1) { Console.WriteLine($" Cantidad de camisas: {camisas}"); Console.WriteLine($"Precio final: {precio} colones"); }
            else if (camisas >= 2 && camisas <= 5)
            {
                double descuento = ((camisas * precio) * 15) / 100;
                double precioFin = (camisas * precio) - descuento;
                Console.WriteLine($" Cantidad de camisas: {camisas}");
                Console.WriteLine($"Precio final: {precioFin} colones");
                Console.WriteLine($"Descuento de 15%: {descuento}");
            }
            else if (camisas > 5)
            {
                double descuento = ((camisas * precio) * 20) / 100;
                double precioFin = (camisas * precio) - descuento;
                Console.WriteLine($" Cantidad de camisas: {camisas}");
                Console.WriteLine($"Precio final: {precioFin} colones");
                Console.WriteLine($"Descuento de 20%: {descuento}");
            }
            else { Console.WriteLine("Cantidad de camisas invalida. Intente de nuevo"); }
        }

        public static void CalculoFin() 
        {
            while (estado2)
            {
                Console.WriteLine("Desea hacer otra compra (1 para si. 2 para no)");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1) { Console.WriteLine("Redirigiendo..."); estado2 = false; }
                else if (opc == 2) { Console.WriteLine("Redirigiendo..."); estado2 = false; estado1 = false; }
                else { Console.WriteLine("Seleccion invalida"); }
            }
        }
    }
}
