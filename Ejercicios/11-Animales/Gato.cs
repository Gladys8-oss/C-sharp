using System;

public class Gato : Mamiferos
{
    public string Pelo { get; set; }

    public bool Domestico { get; set; }
    public void Maullar ()
    {
        Console.WriteLine(Nombre + " Esta Maullando  MIAU..MIAU");
    }

    public override void Comer()
    {
        Console.WriteLine(Nombre + " Esta comiendo");
    }

    public Gato()  // Polimorfismo
   {
       Domestico = true;
   }
   public Gato (bool domestico)
   {
       Domestico = domestico;
   }
}