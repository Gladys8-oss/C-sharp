/*
 * Created by SharpDevelop.
 * User: Kenneth Flores
 * Date: 09/03/2021
 * Time: 09:23 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;

public class FactuCafe {
	
	public List<Cafe> ListadeCafe { get; set; }
	public List<Te> ListadeTe { get; set; }
	public List<Chocolate> ListadeChocolate { get; set; }
	public List<InventarioCafe> ListadeInventario { get; set; }
	public List<Factura> ListadeFacturas { get; set; }
	public List<CafeTender> ListadeCafeTender { get; set; }
	
	public FactuCafe () {
		
		ListadeCafe = new List<Cafe> ();
		cargarCafe();
		
		ListadeTe = new List<Te> ();
		cargarTe();
		
		ListadeChocolate = new List<Chocolate> ();
		cargarChocolate();
		
		ListadeInventario = new List<InventarioCafe> ();
		cargarInventario();
		
		ListadeCafeTender = new List<CafeTender>();
		cargarCafeTender();
		
		ListadeFacturas = new List<Factura> ();
		
	}
	
	public void cargarCafe () {
		
		Cafe c1 = new Cafe ("Americano", "Sencillo", 35, 01);
		ListadeCafe.Add(c1);
		Cafe c2 = new Cafe ("Cappuccino", "Grande", 45, 02);
		ListadeCafe.Add(c2);
		Cafe c3 = new Cafe ("Latte Normal", "Sencillo", 45, 03);
		ListadeCafe.Add(c3);
		Cafe c4 = new Cafe ("Latte Saborizado", "Grande", 65, 04);
		ListadeCafe.Add(c4);
		Cafe c5 = new Cafe ("Mocha Oscuro", "Especial", 60, 05);
		ListadeCafe.Add(c5);
		Cafe c6 = new Cafe ("Mocha Blanco", "Especial", 60, 06);
		ListadeCafe.Add(c6);
		
	}
	
	public void enlistarCafe () {
		
		Console.Clear();
		Console.WriteLine("****************************************************");
		Console.WriteLine("  ************************************************  ");
		Console.WriteLine("		            	MENU DE CAFE                   ");
		Console.WriteLine("  ************************************************  ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine(" \t " + "NO°ORDEN " + " \t " + " CAFE " + " \t " + " TIPO " + " \t " + " PRECIO ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("");
		
		foreach (var cafe in ListadeCafe) {
			
			Console.WriteLine( " \t  "  + cafe.NoOrden + "   \t    " + cafe.Nombre + "   \t    " + cafe.Tipo + "   \t    " + cafe.Precio);
			Console.WriteLine("----------------------------------------------------------------------------");
		}
		
		Console.ReadLine();	
	}
	
	public void cargarTe() {
		
		Te t1 = new Te("Variados Tea", "Especial", 50, 07);
		ListadeTe.Add(t1);
		Te t2 = new Te("Chai Latte", "Especial", 60, 08);
		ListadeTe.Add(t2);
		
	}
	
	public void enlistarTe (){
		
		Console.Clear();
		Console.WriteLine("****************************************************");
		Console.WriteLine("  ************************************************  ");
		Console.WriteLine("		            	MENU DE TE                  ");
		Console.WriteLine("  ************************************************  ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine(" \t " + "NO°ORDEN " + " \t " + " CAFE " + " \t " + " TIPO " + " \t " + " PRECIO ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("");
		
		foreach (var te in ListadeTe) {
			
			Console.WriteLine( " \t  "  + te.NoOrden + "   \t    " + te.Nombre + "   \t    " + te.Tipo + "   \t    " + te.Precio);
			Console.WriteLine("----------------------------------------------------------------------------");
		}
		
		Console.ReadLine();	
	}
	
	public void cargarChocolate () {
		
		Chocolate ch1 = new Chocolate ("Hot Chocolate", "Bomba", 60, 09);
		ListadeChocolate.Add(ch1);
		Chocolate ch2 = new Chocolate ("Marshmellow", "Especial", 65, 10);
		ListadeChocolate.Add(ch2);
		
	}
	
	public void enlistarChocolate () {
		
		Console.Clear();
		Console.WriteLine("****************************************************");
		Console.WriteLine("  ************************************************  ");
		Console.WriteLine("		            	MENU DE CHOCOLATE                  ");
		Console.WriteLine("  ************************************************  ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine(" \t " + "NO°ORDEN " + " \t " + " CAFE " + " \t " + " TIPO " + " \t " + " PRECIO ");
		Console.WriteLine("****************************************************************************");
		Console.WriteLine("");
		
		foreach (var choco in ListadeChocolate) {
			
			Console.WriteLine( " \t  "  + choco.NoOrden + "   \t    " + choco.Nombre + "   \t    " + choco.Tipo + "   \t    " + choco.Precio);
			Console.WriteLine("----------------------------------------------------------------------------");
		}
		
		Console.ReadLine();	
	}
	
	private void cargarInventario () {
		
		InventarioCafe ic1 = new InventarioCafe ("Americano", "Sencillo", 35, 01);
		ListadeInventario.Add(ic1);
		InventarioCafe ic2 = new InventarioCafe ("Cappuccino", "Grande", 45, 02);
		ListadeInventario.Add(ic2);
		InventarioCafe ic3 = new InventarioCafe ("Latte Normal", "Sencillo", 45, 03);
		ListadeInventario.Add(ic3);
		InventarioCafe ic4 = new InventarioCafe ("Latte Saborizado", "Grande", 65, 04);
		ListadeInventario.Add(ic4);
		InventarioCafe ic5 = new InventarioCafe ("Mocha Oscuro", "Especial", 60, 05);
		ListadeInventario.Add(ic5);
		InventarioCafe ic6 = new InventarioCafe ("Mocha Blanco", "Especial", 60, 06);
		ListadeInventario.Add(ic6);
		InventarioCafe ic7 = new InventarioCafe ("Variados Tea", "Especial", 50, 07);
		ListadeInventario.Add(ic7);
		InventarioCafe ic8 = new InventarioCafe ("Chai Latte", "Especial", 60, 08);
		ListadeInventario.Add(ic8);
		InventarioCafe ic9 = new InventarioCafe ("Hot Chocolate", "Bomba", 60, 09);
		ListadeInventario.Add(ic9);
		InventarioCafe ic10 = new InventarioCafe ("Marshmellow", "Especial", 65, 10);
		ListadeInventario.Add(ic10);
		
	}
	
	private void cargarCafeTender () {
		
		CafeTender ct1 = new CafeTender ("Mayra", "Arauz", "3344-3322", 001);
		ListadeCafeTender.Add(ct1);
		CafeTender ct2 = new CafeTender ("Scarleth", "Arauz", "3342-1122", 002);
		ListadeCafeTender.Add(ct2);
		
	}
	
	public void facturacion () 
	{
		Console.Clear();
		Console.WriteLine("Facturacion");
		Console.WriteLine("-----------");
		Console.WriteLine("");
		
		Console.WriteLine("Ingrese el codigo del Cafe Tender: ");
		string nuevoCodigoCafeTender = Console.ReadLine();
		
		CafeTender cafeTender = ListadeCafeTender.Find(c => c.CodigoCafeTender.ToString() == nuevoCodigoCafeTender);
		
		if (cafeTender == null)
		{
			Console.WriteLine("Cafe Tender no encontrado: ");
			Console.ReadLine();
			//return;
		}
		else {
			Console.WriteLine("Nombre Completo: " + cafeTender.Nombre + " | " + cafeTender.Apellido + " Codigo: " + cafeTender.CodigoCafeTender);
			Console.ReadLine();
			Console.WriteLine("");
		}
		
		int nuevoCodigo = ListadeFacturas.Count + 1;
		
		Factura factura = new Factura(nuevoCodigo, DateTime.Now, "Express", cafeTender);
		ListadeFacturas.Add(factura);
		
		Console.WriteLine("Ingrese el numero de orden de su pedido: ");
		string nuevoPedido = Console.ReadLine();
		
		InventarioCafe inventarioCafe = ListadeInventario.Find(ci => ci.NoOrden.ToString() == nuevoPedido);
		
		if (inventarioCafe == null)
		{
			Console.WriteLine("Pedido no encontrado: ");
			Console.ReadLine();
			//return;
		}
		else {
			Console.WriteLine("Descripcion: " + inventarioCafe.Nombre + " Precio: " + inventarioCafe.Precio + " Tipo: " + inventarioCafe.Tipo);
			Console.ReadLine();
			Console.WriteLine("");
		}
		
		Console.WriteLine("Total: " + inventarioCafe.Precio );	
		Console.ReadLine();
		//Console.WriteLine("");
			
	}
	
	public void imprimirFactura() {
		
		Console.Clear();
		Console.WriteLine("Factura");
		Console.WriteLine("");
		
		foreach (var imprimir in ListadeFacturas) {
			
			Console.WriteLine( " \t  "  + imprimir.Fecha + "   \t    " + imprimir.NumerodePedido + "   \t    " + imprimir.CafeTender.Nombre );
			Console.WriteLine("----------------------------------------------------------------------------");
			
			foreach (var imprimir2 in imprimir.ListaDetalledeFactura) {
		
			Console.WriteLine( " \t  "  + imprimir2.InventarioCafe.NoOrden + "   \t    " + imprimir2.InventarioCafe.Precio);
			Console.WriteLine("----------------------------------------------------------------------------");
		}
		 Console.WriteLine();
		}
	  Console.ReadLine();	
	}
}