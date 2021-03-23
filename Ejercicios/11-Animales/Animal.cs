using System;
using System.Collections.Generic;
    public abstract class Animal 
    {

    public string Nombre { get; set; }

    public string Edad { get; set; }

    public string Genero { get; set; }
    public string Animales { get; set; }
    
    public abstract void Comer();
    }