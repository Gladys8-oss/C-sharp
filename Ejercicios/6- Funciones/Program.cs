class Program
{
    struct void Main(string[] args)
    {
        Alumno a = new Alumno(1, "Juan", "Perez");
        Alumno b = new Alumno(2, "Maria", "Martinez");

        a.InactivarAlumno();

        console.WritleLine(a.nombreCompleto());
        console.WritleLine(b.nombreCompleto());

        a.ActivarAlumno();

        console.WriteLine(" ");

        console.WritleLine(a.nombreCompleto());
        console.WritleLine(b.nombreCompleto());
    }
}