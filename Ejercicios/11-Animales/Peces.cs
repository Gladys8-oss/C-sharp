using System;

public abstract  class Peces  :Animal
{
    public int   NumeroAletas { get; set; }
    
    public String Reino { get; set; }

    public string Clase { get; set; }

    public string Orden { get; set; }

    public bool Domestico { get; set; }
    private void nadar ()
    {
          Console.WriteLine(Nombre + "El pez esta nadando...");
    }
}