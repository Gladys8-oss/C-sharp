using System;
using System.Collections.Generic;
public abstract class Mamiferos : Animal
{
    public string Tipo { get; set; }
    public int  Patas { get; set; }
    public string  Raza { get; set; }
    public bool Domesticos { get; set; }
    public string Pelaje { get; set; }
      

   /* public Perro (bool domesticos)
    {
        Domesticos = domesticos;
    }*/

   
        public void Caminar ()
    {
       Console.WriteLine("CAMINANDO");
    }

}