using System;

public class PezGlobo :Peces
{    public string Familia { get; set; }

    public void Inflarse ()
    {
        Console.WriteLine(Nombre + " Esta Inflado");
    }
    
     public  override void Comer()
    {
        Console.WriteLine(Nombre + " Esta comiendo");
    }

}