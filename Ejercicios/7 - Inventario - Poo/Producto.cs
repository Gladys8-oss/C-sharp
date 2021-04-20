public class Producto
{
    public string Codigo { get; set; }
    public string Descripcion { get; set; }

    public int Existencia { get; set; }
    
    public double Precio { get; set; }

    public Producto(string codigo, string descripcion, int existencia, double precio)
    {
        Codigo = codigo;
        Precio = precio;
        Descripcion = descripcion;
        Existencia = existencia;
    }

    
}