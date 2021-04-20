using System;
using System.Collections.Generic;
public class Inventario
{
     public List<Producto> ListadeProductos {get; set; }

     public List<Clientes> ListadeClientes {get; set; }

     public List<Orden> ListaOrdenes { get; set; }
    public Inventario() 
    {
        ListadeProductos = new List<Producto>();
        Producto a = new Producto ("001", "iPhoneX", 1,100);
        Producto b = new Producto ("002", "Laptop Dell", 5,100);
        Producto c = new Producto ("003", "Monitor Samsung", 2,100);
        Producto d = new Producto ("004", "Mouse", 100,100);
        Producto e = new Producto ("005", "Headset", 25,100);

        ListadeProductos.Add(a);
        ListadeProductos.Add(b);
        ListadeProductos.Add(c);
        ListadeProductos.Add(d);
        ListadeProductos.Add(e);


        //CLIENTES
        ListadeClientes = new List<Clientes>();
        Clientes n = new Clientes("Gladys", "Sosa", "gladyssosa22@gmail.com", "Bedeck","99080006", "001");
        ListadeClientes.Add(n);

        //ORDENES
        ListaOrdenes = new List<Orden>();
    }
     
     
     public void listarProductos() {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Productos");
            Console.WriteLine("********************");
            Console.WriteLine("Codigo, Descripcion y Existencia");

              foreach (var producto  in ListadeProductos)
              {
                  Console.WriteLine(producto.Codigo + " | " + producto.Descripcion +" | " + producto.Existencia.ToString());
              }
            Console.ReadLine();
        }

        //Clientes
     public void listarClientes() {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Listado de Clientes");
            Console.WriteLine("********************");
            Console.WriteLine("Nombre   , Apellido  , Correo,    Direccion,  Telefono");

              foreach (var Clientes  in ListadeClientes)
              {
                  Console.WriteLine(Clientes.Nombre + " | " + Clientes.Apellido +" | " + Clientes.Correo 
                  + " | " +  Clientes.Direccion +" | " + Clientes.Telefono);
              }
            Console.ReadLine();
        }
        public void salidaDeInventario() {
	      string codigo = "";
	      string cantidad = "";
	
	        Console.Clear();
            Console.WriteLine();
	        Console.WriteLine("Salida de Productos del Inventario" );
	        Console.WriteLine( "**********************************");
	        Console.WriteLine( "Ingrese el codigo del producto ");
            codigo = Console.ReadLine();
	        Console.WriteLine( "Ingrese la cantidad del producto: ");
	        cantidad = Console.ReadLine();	
	        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
}

         public void AjusteNegativoDeInventario() {
                string codigo = "";
                string cantidad = "";
                
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Ajuste Negativo De Inventario" );
	        Console.WriteLine( "****************************");
	        Console.WriteLine( "Ingrese el codigo del producto ");
            codigo = Console.ReadLine();
	        Console.WriteLine( "Ingrese la cantidad del producto: ");
	        cantidad = Console.ReadLine();	
	        movimientoInventario(codigo, Int32.Parse(cantidad), "-");
            }
            //GUARDAR DATOS DE PRODUCTOS
        private void movimientoInventario(string codigo, int cantidad, string tipoMovimiento) {
            foreach (var producto in ListadeProductos)
            {
               if (producto.Codigo == codigo) {
                    if (tipoMovimiento == "+") {
                        producto.Existencia = producto.Existencia + cantidad;
                    } else {
                         producto.Existencia = producto.Existencia - cantidad;
                    }
                } 
            }
        }

        //GUARDAR DATOS DE CLIENTES
        /* private void movimientoClientes(string nombre, string apellido, string correo, string direccion, string telefono) {
            foreach (var clientes in ListadeClientes)
            {
                clientes.Nombre == clientes.nombre ;
            
        }}*/
         //INGRESO DE PRODUCTOS
        public void ingresoDeInventario() {
            string codigo = "";
            string cantidad = "";

            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ingreso de Productos al Inventario");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();

            movimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }
        //INGRESO DE CLIENTES NUEVOS
        public void ingresoDeClientes() {
            string nombre = "";
            string apellido = "";
            string correo = "";
            string direccion = "";
            string telefono = "";
            string codigo = "";
            Console.Clear();
            Console.WriteLine();

            Console.WriteLine("Ingreso de Clientes al Sistema");
            Console.WriteLine("**********************************");
            Console.Write("Ingrese el nombre del Cliente: ");
            nombre = Console.ReadLine();
            Console.Write("Ingrese el codigo del Cliente: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese el apellido del Cliente: ");
            apellido = Console.ReadLine();
            Console.Write("Ingrese el correo del Cliente: ");
            correo = Console.ReadLine();
            Console.Write("Ingrese el direccion del Cliente: ");
            direccion = Console.ReadLine();
            Console.Write("Ingrese el telefono del Cliente: ");
            telefono = Console.ReadLine();
            Clientes NuevoCliente = new Clientes ( nombre, apellido, correo , direccion, telefono,codigo);
            ListadeClientes.Add(NuevoCliente);
        }
            public  void AjustePositivoDeInventario() {
            string codigo = "";
            string cantidad = "";
    
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("Ajuste Positivo de Inventario");
            Console.WriteLine("*****************************");
            Console.Write("Ingrese el codigo del producto: ");
            codigo = Console.ReadLine();
            Console.Write("Ingrese la cantidad del producto: ");
            cantidad = Console.ReadLine();
            
           movimientoInventario(codigo, Int32.Parse(cantidad), "+");
        }

        //CREAR PEDIDOS

         public void CrearOrden()
    {
        Console.WriteLine("Creando Orden");
        Console.WriteLine("=============");
        Console.WriteLine("");

        Console.WriteLine("Ingrese el codigo del cliente: ");
        string codigoCliente = Console.ReadLine();

        Clientes cliente = ListadeClientes.Find(c => c.Codigoc.ToString() == codigoCliente);        
        if (cliente == null)
        {
            Console.WriteLine("Cliente no encontrado");
            Console.ReadLine();
            return;
        } else {
            Console.WriteLine("Cliente: " + cliente.Nombre);
            Console.WriteLine("");
        }

        Console.WriteLine("Ingrese el codigo del vendedor: ");
        string codigoVendedor = Console.ReadLine();

       /* Vendedor vendedor = ListadeVendedores.Find(v => v.Codigo.ToString() == codigoVendedor);
        if (vendedor == null) 
        {
            Console.WriteLine("Vendedor no encontrado");
            Console.ReadLine();
           
        } else {
            Console.WriteLine("Vendedor: " + vendedor.Nombre);
            Console.WriteLine("");
        }*/

        int nuevoCodigo = ListaOrdenes.Count + 1;

        Orden nuevaOrden = new Orden(nuevoCodigo, DateTime.Now, "SPS" + nuevoCodigo, cliente);
        ListaOrdenes.Add(nuevaOrden);

        while(true)
        {
            Console.WriteLine("Ingrese el producto: ");
            string codigoProducto = Console.ReadLine();
            Producto producto = ListadeProductos.Find(p => p.Codigo.ToString() == codigoProducto);        
            if (producto == null)
            {
                Console.WriteLine("Producto no encontrado");
                Console.ReadLine();
            } else {
                Console.WriteLine("Producto agregado: " + producto.Descripcion + " con precio de: " + producto.Precio);
                nuevaOrden.AgregarProducto(producto);
            }

            Console.WriteLine("Desea continuar? s/n");
            string continuar = Console.ReadLine();
            if (continuar.ToLower() == "n") {
                break;
            }
        }

        Console.WriteLine("");
        Console.WriteLine("Subtotal de la Orden es de: " + nuevaOrden.SubTototal);
        Console.WriteLine("Impuesto de la orden es de: " + nuevaOrden.Impuesto);
        Console.WriteLine("----------------------------------");
        Console.WriteLine("Total de la orden es de:    " + nuevaOrden.Total);
        Console.ReadLine();
    }

    // LISTAR ORDENES

    public void ListarOrdenes()
    {
        Console.Clear();
        Console.WriteLine("Lista de Ordenes");
        Console.WriteLine("================");
        Console.WriteLine("");  
        
        foreach (var orden in ListaOrdenes)
        {
            Console.WriteLine( " Codigo " + "         Fecha  " + "              Subtotal  " + "     Impuesto  " + "  Total  ");
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine(orden.Codigo +    " |     "    + orden.Fecha +     " |      "    + orden.SubTototal +     " |         "  + orden.Impuesto + " |        " + orden.Total);
            Console.WriteLine("");
            Console.WriteLine("Cliente : " + orden.Cliente.Nombre + "    | ");
            Console.WriteLine();
            Console.WriteLine("");  
            Console.WriteLine("----------------------------------------------------------------------------------");
            Console.WriteLine(""); 
            foreach (var detalle in orden.ListaOrdenDetalle)
            {
                Console.WriteLine("Descripcion   " + "Cantidad   " + "Precio");
                Console.WriteLine(" " + detalle.Producto.Descripcion + "      |    " + detalle.Cantidad + "     |  " + detalle.Producto.Precio);
            }
            
            Console.WriteLine();
        } 

        Console.ReadLine();
    }
}