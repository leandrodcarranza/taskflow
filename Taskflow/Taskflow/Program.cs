namespace Taskflow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }
        static void ListarTarea(list<Tarea> lista) 
        {
            Console.WriteLine("Lista de Tareas");
            if (lista.count == 0)
            {
                Console.WriteLine("No hay tareas registradas aun").
            }
            else 
            {
                foreach (var t in lista)
                {
                    Console.WriteLine($"{t.id}-{(.EstaCompletada ? "OK" : "..")}- {t.Descripcion}");
                }
            }
        }
    }
}
