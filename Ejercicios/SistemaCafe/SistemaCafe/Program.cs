/*
 * Created by SharpDevelop.
 * User: Kenneth Flores
 * Date: 09/03/2021
 * Time: 09:06 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace SistemaCafe
{
	
	class Program
	{
		public static void Main(string[] args)
		{
			Login login = new Login();
			login.user();
			FactuCafe factuCafe = new FactuCafe();
            string opcion = "";

            while (true)
            {
                Console.Clear();
                Console.WriteLine("\t ===========================================================  ");
                Console.WriteLine("\t||  ****************************************************** || ");
                Console.WriteLine("\t||                      SISTEMA DE CAFE                    || ");
                Console.WriteLine("\t||  ****************************************************** || ");
                Console.WriteLine("\t ===========================================================  ");
                Console.WriteLine("\t                        Cafe Patagotitan                      ");
                Console.WriteLine("\t            Disfruta del Buen Cafe, como Dios manda           ");
                Console.WriteLine("");
                Console.WriteLine("\t\t\t     BEBIDAS CALIENTES");
                Console.WriteLine("\t\t\t     1 - Menu de Cafe");
                Console.WriteLine("\t\t\t     2 - Menu de Te");
                Console.WriteLine("\t\t\t     3 - Menu de Chocolate");
                Console.WriteLine("");
                Console.WriteLine("\t\t\t     SALIDAS DE FACTURAS");
                Console.WriteLine("\t\t\t     4 - Facturar Pedido");
                Console.WriteLine("\t\t\t     5 - Facturas Realizadas");
                Console.WriteLine("\t\t\t     6 - Salida de Facturas");
                Console.WriteLine("\t\t\t     0 - Salir");
                Console.WriteLine("");
                Console.WriteLine("Seleccione un Menu");
                opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                		factuCafe.enlistarCafe();
                        break;
                    case "2":
                        factuCafe.enlistarTe();
                        break;
                    case "3":
                        factuCafe.enlistarChocolate();
                        break;
                    case "4":
                        factuCafe.facturacion();
                        break;      
                    case "5":
                        factuCafe.imprimirFactura();
                        break;
					case "6":
                        //factuCafe.imprimirFactura();
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