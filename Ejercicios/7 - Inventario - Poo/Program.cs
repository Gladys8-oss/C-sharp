using System;

namespace inventario
{
class Program
{
static void Main(string[] args)
{
    string opcion = "";
    Inventario inventario = new Inventario ();
    while (true)
    {
        Console.Clear();
        Console.WriteLine("Sistema de Inventario");
        Console.WriteLine("*********************");
        Console.WriteLine("");
        Console.WriteLine("1 - Productos");
        Console.WriteLine("2 - Ingreso de Inventario");
        Console.WriteLine("3 - Salida de Inventario");
        Console.WriteLine("4 - Ajuste Positivo");
        Console.WriteLine("5 - Ajuste Negativo");
        Console.WriteLine("6 - Ingreso de Clientes");
        Console.WriteLine("7 - Clientes");
        Console.WriteLine("8 - Crear Orden");
        Console.WriteLine("9 - Crear Orden");
        Console.WriteLine("0 - Salir");
        opcion = Console.ReadLine();

        switch (opcion)
        {
            case "1": 
                inventario.listarProductos();
                break;
            case "2":
                inventario.ingresoDeInventario();
                break;

            case "3":
            inventario.salidaDeInventario();
            break;

            case "4":
            inventario.AjustePositivoDeInventario();
            break;

            case "5":
            inventario.AjusteNegativoDeInventario() ;
            break;

            case "6":
            inventario.ingresoDeClientes() ;
            break;

            case "7":
            inventario.listarClientes();
            break;

            case "8":
            inventario.CrearOrden();
            break;

            case "9":
            inventario.ListarOrdenes();
            break;
            default:
            break;
        }

        if (opcion == "0") {
            break;
        }
    }            
}
}
}