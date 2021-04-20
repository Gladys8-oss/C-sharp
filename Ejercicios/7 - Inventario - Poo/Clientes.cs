using System;
using System.Collections.Generic;
public class Clientes 
{
    public string Nombre { get; set; }
    public string Codigoc { get; set; }
    public string Apellido { get; set; }

    public string Direccion { get; set; }

    public string Correo { get; set; }

    public string Telefono { get; set; }

    public List<Clientes> ListaOrdenCliente { get; set; }

    public Clientes (string nombre , string apellido , string direccion , string correo , string telefono, string codigoc )
    {
        Codigoc = codigoc;
        Nombre = nombre;
        Apellido = apellido;
        Direccion = direccion;
        Correo = correo;
        Telefono = telefono;
        ListaOrdenCliente = new List<Clientes>();
    }


   public void AgregarCliente(Clientes clientes)
    {
      //int nuevoCodigo =  ListaOrdenDetalle.Count + 1;
     // int cantidad = 1;

      Clientes o = new Clientes (Nombre , Apellido, Direccion, Correo, Telefono,Codigoc);
      ListaOrdenCliente.Add(o);

    }
}
