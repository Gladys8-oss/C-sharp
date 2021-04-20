using System;
class Propietario 
{
    public string Identidad { get; set; }

    public string Nombre { get; set; }

    public string Correo { get; set; }

    public string Telefono { get; set; }

    public string Direccion { get; set; }

    
    public void RegistrarPropietario() // Esta funcion pide los datos de los nuevos propietarios de cuentas
    {
        Console.WriteLine("Nombre Propietario");
        Nombre = Console.ReadLine();
        Console.WriteLine("Identidad: ");
        Identidad = Console.ReadLine();
        Console.WriteLine("Numero de Telefono: ");
        Telefono= Console.ReadLine();
        Console.WriteLine("Direccion: ");
        Direccion = Console.ReadLine();
        Console.WriteLine("Correo electronico: ");
        Correo = Console.ReadLine();
    }
}