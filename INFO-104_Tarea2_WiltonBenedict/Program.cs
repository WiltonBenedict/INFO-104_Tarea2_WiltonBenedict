using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//UH, Wilton Benedict Castillo
//INFO-104 Programacion 2
//Prof. Alexander Benjamin Curling
//Tarea 2
//9/24/2023
// Diagrama de flujo de algoritmo 3: https://app.code2flow.com/8OAwiRy5MBP6
namespace INFO_104_Tarea2_WiltonBenedict
{
    internal class Program
    {
        static void Main(string[] args)
        {   
            //Menu principal. Se utiliza para ingresar a los algoritmos requeridos. Utiliza un dato bool para mantener o salir del menu.
            bool estado = true;
            while (estado) 
            {
                Console.WriteLine("Directorio Tarea 2. INFO-104. UH. Wilton Benedict");
                Console.WriteLine("Por favor seleccione el numero de algoritmo a inicializar: ");
                Console.WriteLine("1. Tienda que vende camisas.");
                Console.WriteLine("2. Calcular promedio final para un estudiante.");
                Console.WriteLine("3. Venta de productos.");
                Console.WriteLine("4. Salida");
                Console.WriteLine("Ingrese su seleccion: ");
                int opc = int.Parse(Console.ReadLine());

                if( opc == 1 ) { Algoritmo1(); }//redirige a metodo del algoritmo 1 solicitado
                else if( opc == 2 ) {  Algoritmo2(); }//redirige a metodo del algoritmo 2 solicitado
                else if ( opc == 3 ) {  Algoritmo3(); }//redirige a metodo del algoritmo 3 solicitado
                else if ( opc == 4 ) { estado = false; }//termina el programa
                else { Console.WriteLine("Opcion invalida. Intente de nuevo"); }//validacion en caso que el dato ingresado no sea valido
            }
        }

        public static void Algoritmo1()
        {
            bool estado1 = true;
            while (estado1) 
            { 
            Console.WriteLine("--Algoritmo 1--");
            Console.WriteLine(" Tienda de venta de camisas ");
            Console.WriteLine("¡Bievenido/a a la tienda de camisas!");
            Console.WriteLine("¡Promociones disponibles!");
            Console.WriteLine("\t 2 a 5 camisas con 15%");
            Console.WriteLine("\t 5 o mas camisas con 20%");
            Console.WriteLine("Por favor ingrese la cantidad de camisas: ");
            int camisas = int.Parse(Console.ReadLine());
            Console.WriteLine("Por favor ingrese la cantidad el precio de las camisas: ");
            int precio = int.Parse(Console.ReadLine());
                //Estructura de control para decidir el descuento aplicado
            if(camisas == 1) { Console.WriteLine($" Cantidad de camisas: {camisas}"); Console.WriteLine($"Precio final: {precio} colones"); }
            else if ( camisas >= 2 && camisas<=5) 
            {
                double descuento = ((camisas * precio) * 15) / 100;
                    double precioFin = (camisas * precio) - descuento;
                Console.WriteLine($" Cantidad de camisas: {camisas}");
                Console.WriteLine($"Precio final: {precioFin} colones");
                Console.WriteLine($"Descuento de 15%: {descuento}");
            }
            else if (camisas >5)
            {
                double descuento = ((camisas * precio) * 20) / 100;
                double precioFin = (camisas * precio) - descuento;
                Console.WriteLine($" Cantidad de camisas: {camisas}");
                Console.WriteLine($"Precio final: {precioFin} colones");
                Console.WriteLine($"Descuento de 20%: {descuento}");
            }
            else { Console.WriteLine("Cantidad de camisas invalida. Intente de nuevo"); }

            bool estado2 = true;
            while (estado2)
            {
                Console.WriteLine("Desea hacer otra compra (1 para si. 2 para no)");
                int opc = int.Parse(Console.ReadLine());
                if(opc == 1) { Console.WriteLine("Redirigiendo..."); estado2 = false; }
                else if(opc == 2) { Console.WriteLine("Redirigiendo..."); estado2= false; estado1 = false; }
                else { Console.WriteLine("Seleccion invalida"); }
            }


            }
        }

        public static void Algoritmo2()
        {
            bool estado1 = true;
            while(estado1) 
            {
                //arreglos para almacenar notas de las asignaturas
                float[] quiz = new float[3];
                float[] tareas = new float[3];
                float[] examenes = new float[3];
                string nombre, carnet;
                float porQuiz, porTarea, porExamen,finQuiz = 0, finTarea = 0, finExamen = 0, notaFin = 0;

                Console.WriteLine("--Algoritmo 2--");
                Console.WriteLine("Calculadora Promedio Final del Curso de Programacion I");
                Console.WriteLine("Nota: A continuacion se le solicitaran la informacion del estudiante");
                Console.WriteLine("Ingrese carnet del estudiante: ");
                carnet = Console.ReadLine();
                Console.WriteLine("Ingrese nombre del estudiante: ");
                nombre = Console.ReadLine();

                //Uso de estructuras de repeticion for para almacenar los datos de las notas
                int sCont = 1;
                for (int cont = 0; cont < 3; cont++) 
                {
                    Console.WriteLine($"Ingrese la nota del quiz {sCont}: ");
                    float dato = float.Parse(Console.ReadLine());
                    quiz[cont] = dato;
                    sCont++;
                }
                sCont = 1;
                for (int cont = 0; cont < 3; cont++)
                {
                    Console.WriteLine($"Ingrese la nota de la tarea {sCont}: ");
                    float dato = float.Parse(Console.ReadLine());
                    tareas[cont] = dato;
                    sCont++;
                }
                sCont = 1;
                for (int cont = 0; cont < 3; cont++)
                {
                    Console.WriteLine($"Ingrese la nota del examen {sCont}: ");
                    float dato = float.Parse(Console.ReadLine());
                    examenes[cont] = dato;
                    sCont++;
                }
                //Se utiliza estructura repetitiva for para calcular la nota final primero calculando el porcentaje de la asignatura individual y despues agregandola a un acumulador
                for (int cont = 0;cont < 3; cont++)
                {
                    porQuiz = (quiz[cont]* 8.3f) / 100;
                    finQuiz = finQuiz + porQuiz;

                    porTarea = (tareas[cont] * 10) / 100;
                    finTarea = finTarea + porTarea;

                    porExamen = (examenes[cont] * 15) / 100;
                    finExamen = finExamen + porExamen;
                }
                notaFin = finQuiz + finTarea + finExamen;
                //estructura de control para decidir si la nota final es valida y su estado (aprobada, aplazado, reprobado)
                if (notaFin >= 70) 
                {
                    Console.WriteLine($"Estudiante: {nombre}\n Carnet: {carnet}");
                    Console.WriteLine($"Estado: Aprobado\n Nota Final: {notaFin}\n Quizzes:{finQuiz}%\n Tareas: {finQuiz}%\n Examenes: {finExamen}%"); 
                
                }
                else if (notaFin >=50 &&  notaFin <=70) 
                {
                    Console.WriteLine($"Estudiante: {nombre}\n Carnet: {carnet}");
                    Console.WriteLine($"Estado: Aplazado\n Nota Final: {notaFin}\n Quizzes:{finQuiz}%\n Tareas: {finQuiz}%\n Examenes: {finExamen}%"); 
                }
                else if(notaFin <50) 
                {
                    Console.WriteLine($"Estudiante: {nombre}\n Carnet: {carnet}");
                    Console.WriteLine($"Estado: Reprobado\n Nota Final: {notaFin}\n Quizzes:{finQuiz}%\n Tareas: {finQuiz}%\n Examenes: {finExamen}%"); 
                }
                else if (notaFin <0 || notaFin > 100) { Console.WriteLine("Hay problemas en el calculo ya que la nota final es negativa o mayor a 100"); }

                bool estado2 = true;
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

        public static void Algoritmo3()
        {
            bool estado1 = true;
            while (estado1)
            {
                int producto, precioFin;
                Console.WriteLine("--Algoritmo 3--");
                Console.WriteLine("Bienvenido/a al sistema de compras de producto");
                Console.WriteLine("Nota: Si compra mas de 10 productos, el precio por unidad sera de 15$ en vez de 20$");
                Console.WriteLine("Ingrese la cantidad de productos a comprar: ");
                producto = int.Parse(Console.ReadLine());
                //estructura selectiva para decidir si el precio a aplicar es 15$ o 20$
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


                bool estado2 = true;
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
}
