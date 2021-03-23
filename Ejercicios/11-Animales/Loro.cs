using System;

public class Loro :Aves
{
    public bool LoroHablar { get; set; }

    public int Longitud { get; set; }
    public void Hablar ()
    {
        LoroHablar = true;
    }
     public  override void Comer()
    {
        Console.WriteLine(Nombre + " Esta comiendo");
    }
}