namespace Taskflow
{
    class Program
    {
        static void Main(string[] args)
        {
            GestorTareas gestor = new GestorTareas();

            Console.WriteLine("Ingrese el nombre de la tarea:");
            string nombre = Console.ReadLine();

            gestor.CrearTarea(nombre);

            Console.ReadKey();
        }
    }
}
// Cambio distinto desde main