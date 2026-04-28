using System;

public class Tarea
{
    public string Nombre { get; set; }
    public object Descripcion { get;  set; }
    public object Titulo { get;  set; }
    
    public Tarea(string nombre)
    {
        Nombre = nombre;
    }

}
