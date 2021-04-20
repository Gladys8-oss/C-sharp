/*
 * Created by SharpDevelop.
 * User: Kenneth Flores
 * Date: 09/03/2021
 * Time: 04:44 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;

public class Factura {
	
	public int Codigo { get; set; }
	public DateTime Fecha { get; set; }
    public string NumerodePedido { get; set; }
    public CafeTender CafeTender { get; set; }
    public List<DetalledeFactura> ListaDetalledeFactura { get; set; }
    public double Total { get; set; }
    
    public Factura (int codigo, DateTime fecha, string numerodePedido, CafeTender cafeTender)
    {
    	Codigo = codigo;
    	Fecha = fecha;
    	NumerodePedido = numerodePedido;
    	CafeTender = cafeTender;
    	ListaDetalledeFactura = new List<DetalledeFactura>();
    }
    
    public void agregarPedido (InventarioCafe inventarioCafe)
    {
    	int nuevoCodigo = ListaDetalledeFactura.Count + 1;
        
    	DetalledeFactura detalledeFactura = new DetalledeFactura(nuevoCodigo, 1, inventarioCafe);
    	ListaDetalledeFactura.Add(detalledeFactura);
    	
    	
    	Total = inventarioCafe.Precio;
    }
}