using System;

namespace Taskflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string estado = "Pendientes";

            Console.WriteLine("Estado actual de la tarea: " + estado);

            estado = "En progreso";
            Console.WriteLine("Estado actualizado: " + estado);

            estado = "Completada";
            Console.WriteLine("Estado final: " + estado);
            Console.WriteLine("La tarea fue completada correctamente.");
        }
    }
}
