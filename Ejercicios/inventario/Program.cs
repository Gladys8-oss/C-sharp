using System;

namespace propiedades
{
    class Program
    {
        static void Main(string[] args)
        {
            Alumno a = new Alumno();
            a.Id = 1;
            a.PrimerNombre = "Juan";
            a.SegundoNombre = "Perez";

            Alumno b = new Alumno();
            b.Id = 1;
            b.PrimerNombre = "Maria";
            b.SegundoNombre = "Martinez";
        }
    }
}