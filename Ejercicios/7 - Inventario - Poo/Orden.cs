using System;
using System.Collections.Generic;
public class Orden
{
    public int Codigo { get; set; }

    public DateTime Fecha { get; set; }

    public string NumerodeOrden { get; set; }

    public Clientes Cliente{ get; set; }

    public List<OrdenDetalle> ListaOrdenDetalle { get; set; }
    public double Total { get; set; }
    public double SubTototal { get; set; }

    public double Impuesto { get; set; }
  
   public Orden (int codigo, DateTime fecha, string numerodeorden,Clientes cliente)//Cliente cliente, Vendedor vendedor
    {
        Codigo = codigo;
        Fecha = fecha;
        NumerodeOrden = numerodeorden;
        Cliente = cliente;
      //  Vendedor = vendedor;
        ListaOrdenDetalle = new List<OrdenDetalle>();
    }

    //Agregar producto a una nueva orden
    public void AgregarProducto(Producto producto)
    {
      int nuevoCodigo =  ListaOrdenDetalle.Count + 1;
      int cantidad = 1;

      OrdenDetalle o = new OrdenDetalle (nuevoCodigo , 1, producto);
      ListaOrdenDetalle.Add(o);

      SubTototal += cantidad * producto.Precio;
      Impuesto =+ SubTototal * 0.15;
      Total += SubTototal + Impuesto;
    }
}
