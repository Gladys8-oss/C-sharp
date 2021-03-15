using System;

namespace 10_Ordenes
{
    class Program
    {
        static void Main(string[] args) 
        {
            DatosdePrueba datos = new DatosdePrueba();
            string Opcion ="";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("Sistema de Ordenes");
                Console.WriteLine("==================");
                Console.WriteLine("");
                Console.WriteLine("1 - Lista de Productos");
                Console.WriteLine("2 - Crear Orden");
                Console.WriteLine("3 - Lista de Clientes");
                Console.WriteLine("4 - Lista de Vendedores");
                Console.WriteLine("5 - Lista de Ordenes");
                Console.WriteLine("0 -  Salir");
                Opcion =Console.ReadLine();
                switch (Opcion)
                {
                    case "1":
                    datos.ListadeProductos();
                    break;
                    default:
                    break;
                }

                if (Opcion == "0"){
                    break;
                }
            }
        }
    }
}