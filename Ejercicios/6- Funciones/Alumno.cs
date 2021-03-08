public class Alumno
{

    public int Id { get; set; }

    public string PrimerNombre { get; set; }

    public string SegundoNombre { get; set; }

    public bool Activo{ get; set; }

    Public Alumno (int id, string primerNombre, string segundoNombre)
    {
        Id = id;
        PrimerNombre = primerNombre;
        SegundoNombre = segundoNombre;
        Activo = true;
    }

    public string nombreCompleto() {
        if (Activo == true) {
        return PrimerNombre + "" + SegundoNombre;
       
        }
       
       return "Alumno inactivo";
    }

    pulic void InactivarAlumno() {
        Activo = false;
    }

    pulic void ActivarAlumno() {
        Activo = true;
    }
}