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
namespace INF0_104_Tarea2_Algoritmo3_WiltonBenedict
{
    internal class Program
    {
        static int producto;
        static int precioFin = 0;
        static bool estado1 = true; static bool estado2 = true;
        static void Main(string[] args)
        {
            while (estado1) 
            { 
                estado2 = true;
                Inicio();
                CalculoProducto();
                CalculoFin();
            }
            
        }
        public static void Inicio() 
        
        {
            Console.WriteLine("--Algoritmo 3--");
            Console.WriteLine("Bienvenido/a al sistema de compras de producto");
            Console.WriteLine("Nota: Si compra mas de 10 productos, el precio por unidad sera de 15$ en vez de 20$");
            Console.WriteLine("Ingrese la cantidad de productos a comprar: ");
            producto = int.Parse(Console.ReadLine());
        }
        public static void CalculoProducto()
        {
            if (producto <= 10)
            {
                precioFin = producto * 20;
                Console.WriteLine($"Costo Final: {precioFin}$\n Cantidad: {producto}");
            }
            else if (producto > 10)
            {
                precioFin = producto * 15;
                Console.WriteLine($"Costo Final: {precioFin}$\n Cantidad: {producto}\n Nota: descuento aplicado de 15%");
            }
            else { Console.WriteLine("Cantidad de producto invalida. Intente de nuevo"); }

        }

        public static void CalculoFin()
        {
            while (estado2)
            {
                Console.WriteLine("Desea hacer otro calculo (1 para si. 2 para no)");
                int opc = int.Parse(Console.ReadLine());
                if (opc == 1) { Console.WriteLine("Redirigiendo..."); estado2 = false; }
                else if (opc == 2) { Console.WriteLine("Redirigiendo..."); estado2 = false; estado1 = false; }
                else { Console.WriteLine("Seleccion invalida"); }
            }
        }
    }
}
