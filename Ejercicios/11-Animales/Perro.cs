using System;
public class Perro : Mamiferos   // Herencia
{
    public int Codigo { get; set; }
    public bool Domestico { get; set; }
    public void Ladrar ()   // Abstracion
    {
      Console.WriteLine(Nombre + " Esta ladrando Gua..Gua");
    }
    public  override void Comer()
    {
        Console.WriteLine(Nombre + " Esta comiendo");
    }
   public Perro()  // Polimorfismo
   {
       Domestico = true;
   }
   public Perro(bool domestico)
   {
       Domestico = domestico;
   }
    public void Tamano() // Encapsulamiento
    {
        DescribirTamano();
    }

    private void DescribirTamano()
    {
     string Ta = "";
     Console.WriteLine("Ingrese el tamaño del perro");
     Ta =Console.ReadLine();
     if (Ta == "Grande")
     {
        Console.WriteLine("Corra");
     } else if (Ta == "Pequeño")
     {
        Console.WriteLine("Todo esta bien no hay peligro");
     }
    }
}