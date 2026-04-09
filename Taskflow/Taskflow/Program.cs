using System;
using System.Collections.Generic;
namespace Taskflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Tarea>ListaDePrueba = new List<Tarea> ();

            Console.WriteLine("Iniciando sistema de Tareas");
            ListarTarea(ListaDePrueba);
        }
        static void ListarTarea(list<Tarea> lista) 
        {
            Console.WriteLine("Lista de Tareas");
            if (lista.Count== 0)
            {
                Console.WriteLine("No hay tareas registradas aun").
            }
            else 
            {
                foreach (var t in lista)
                {
                    Console.WriteLine($"{t.Id}{(.EstaCompletada ? "OK" : "..")}- {t.Descripcion}");
                }
            }
        }
    }
}
