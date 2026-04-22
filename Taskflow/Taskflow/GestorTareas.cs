using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Taskflow
{

    public class GestorTareas
    {
        private List<Tarea> tareas = new List<Tarea>();

        public void CrearTarea(string nombre)
        {
            if (string.IsNullOrWhiteSpace(nombre))
            {
                Console.WriteLine("Error: el nombre no puede estar vacío.");
                return;
            }

            Tarea tarea = new Tarea(nombre);
            tareas.Add(tarea);

            Console.WriteLine($"Tarea '{nombre}' creada correctamente.");
        }
    }
}
