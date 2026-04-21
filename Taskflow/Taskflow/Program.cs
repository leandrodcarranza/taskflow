using System;

namespace Taskflow
{
    class Program
    {
        static void Main(string[] args)
        {
 feature/estado-tarea
            string estado = "Pendientes";

            Console.WriteLine("Estado actual de la tarea: " + estado);

            estado = "En progreso";
            Console.WriteLine("Estado actualizado: " + estado);

            estado = "Completada";
            Console.WriteLine("Estado final: " + estado);
            Console.WriteLine("La tarea fue completada correctamente.");

            GestorTareas gestor = new GestorTareas();

            Console.WriteLine("Ingrese el nombre de la tarea:");
            string nombre = Console.ReadLine();

            gestor.CrearTarea(nombre);

            Console.ReadKey();
 main
        }
    }
}


// cambio desde feature conflictos

// Cambio distinto desde main

