using System;
 feature/listar-tarea
using System.Collections.Generic;

namespace Taskflow
{
    public class ListarTarea
=======

namespace Taskflow
{
    class Program
 main
    {
        public string Titulo { get; set; }
        public string Descripcion { get; set; }

        public static void ListarTareas(List<Tarea> tareas)
        {
 feature/listar-tarea
            foreach (var tarea in tareas)
            {
                Console.WriteLine($"Titulo: {tarea.Titulo}");
                Console.WriteLine($"Descripcion: {tarea.Descripcion}");
                Console.WriteLine("-----------------------------------");
            }
        }
    }
}
=======
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

 main
