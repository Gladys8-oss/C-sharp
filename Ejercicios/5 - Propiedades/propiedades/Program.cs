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

            Alumno c = new Alumno();
            c.Id = 1;
            c.PrimerNombre = "Maria";
            c.SegundoNombre = "Martinez";

            Alumno d = new Alumno();
            c.PrimerNombre = "Pedro";

            Alumno e =new Alumno("Juan", "Jimenez");
            Console.WriteLine(a.Id);
            Console.WriteLine(c.Id);
            Console.WriteLine(d.Id);
            Console.WriteLine(d.PrimerNombre +" "+ d.SegundoNombre);
        }
    }
}
