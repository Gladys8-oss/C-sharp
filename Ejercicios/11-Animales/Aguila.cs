using System;

public  class Aguila : Aves
{

    public void VolarAlto ()
    {
        Console.WriteLine(Nombreave + " Esta Gritando"); 
    }

    public  override void Comer()
    {
        Console.WriteLine(Nombre + " Esta comiendo");
    }
}