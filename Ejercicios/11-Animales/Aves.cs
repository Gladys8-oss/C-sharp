using System;

public abstract class Aves : Animal
{
    public string  ColorPlumaje { get; set; }

   public string Nombreave { get; set; }

   public int Velocidad { get; set; }

   public int LongitudAlas { get; set; }

   public int Patas { get; set; }

   public string Pelaje { get; set; }

   public bool Domestico { get; set; }
    public void Volar (string colorplumaje)
    {

     ColorPlumaje = colorplumaje;

    }
}