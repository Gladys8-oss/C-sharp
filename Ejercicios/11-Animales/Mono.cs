using System;
using System.Collections.Generic;
public class Mono : Mamiferos
{
   // public string  Tipo { get; set; }
    
    public int Extremidades { get; set; }
    public bool Domestico { get; set; }
    public void Gritar()
    {
     Console.WriteLine(Nombre + " Esta Gritando");   
    }

    public override void Comer()
    {
        Console.WriteLine(Nombre + " Esta comiendo");
    }
}