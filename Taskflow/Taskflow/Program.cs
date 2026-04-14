using System.Formats.Tar;





public class Listar_tarea
{  
    public string Titulo {get;set;}
    public string Descripcion { get;set;}

    public static void ListarTareas(List<Tarea>tareas) 
    {
        foreach (var tarea  in tareas) 
        {
            Console.WriteLine($"Titulo: {tarea.Titulo}");
            Console.WriteLine($"Descripcion: {tarea.Descripcion}");
            Console.WriteLine("-----------------------------------");
        }
    }
    
}