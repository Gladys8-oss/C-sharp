/*
 * Created by SharpDevelop.
 * User: Kenneth Flores
 * Date: 09/03/2021
 * Time: 04:48 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;
using System.Collections.Generic;

public class DetalledeFactura {
	
	public int Codigo { get; set; }
    public int Cantidad { get; set; }
    public double Precio { get; set; }
    public InventarioCafe InventarioCafe { get; set; }
    
    public DetalledeFactura ( int codigo, int cantidad, InventarioCafe inventarioCafe)
    {
    	Codigo = codigo;
    	Cantidad = cantidad;
    	InventarioCafe = inventarioCafe;
    	Precio = inventarioCafe.Precio;
    	
    }	
}