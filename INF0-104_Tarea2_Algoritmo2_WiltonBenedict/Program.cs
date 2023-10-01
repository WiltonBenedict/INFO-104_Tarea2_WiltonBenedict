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
namespace INF0_104_Tarea2_Algoritmo2_WiltonBenedict
{
    internal class Program
    {
        static float[] quiz = new float[3];
        static float[] tareas = new float[3];
        static  float[] examenes = new float[3];
        static string nombre, carnet;
        static bool estado1 = true; static bool estado2 = true;
        static float porQuiz = 0, porTarea=0, porExamen=0, finQuiz = 0, finTarea = 0, finExamen = 0, notaFin = 0;
        static void Main(string[] args)
        {
            while (estado1) 
            { 
            estado2 = true;
            ColeccionDatos();
            CalculoNotas();
            Resultados();
            CalculoFin();
            }
        }
        public static void ColeccionDatos()
        {
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
        }
        
        public static void CalculoNotas()
        {
            for (int cont = 0; cont < 3; cont++)
            {
                porQuiz = (quiz[cont] * 8.3f) / 100;
                finQuiz = finQuiz + porQuiz;

                porTarea = (tareas[cont] * 10) / 100;
                finTarea = finTarea + porTarea;

                porExamen = (examenes[cont] * 15) / 100;
                finExamen = finExamen + porExamen;
            }
            notaFin = finQuiz + finTarea + finExamen;
        }
    
        public static void Resultados()
        {
            if (notaFin >= 70)
            {
                Console.WriteLine($"Estudiante: {nombre}\n Carnet: {carnet}");
                Console.WriteLine($"Estado: Aprobado\n Nota Final: {notaFin}\n Quizzes:{finQuiz}%\n Tareas: {finTarea}%\n Examenes: {finExamen}%");

            }
            else if (notaFin >= 50 && notaFin <= 70)
            {
                Console.WriteLine($"Estudiante: {nombre}\n Carnet: {carnet}");
                Console.WriteLine($"Estado: Aplazado\n Nota Final: {notaFin}\n Quizzes:{finQuiz}%\n Tareas: {finTarea}%\n Examenes: {finExamen}%");
            }
            else if (notaFin < 50)
            {
                Console.WriteLine($"Estudiante: {nombre}\n Carnet: {carnet}");
                Console.WriteLine($"Estado: Reprobado\n Nota Final: {notaFin}\n Quizzes:{finQuiz}%\n Tareas: {finQuiz}%\n Examenes: {finExamen}%");
            }
            else if (notaFin < 0 || notaFin > 100) { Console.WriteLine("Hay problemas en el calculo ya que la nota final es negativa o mayor a 100"); }

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
