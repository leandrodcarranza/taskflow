using System;

public class Tarea
{
    public string Nombre { get; set; }
    public bool Completada { get; set; }

    public void MarcarComoCompletada()
    {
        Completada = true;
    }

}
