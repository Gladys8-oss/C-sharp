/*
 * Created by SharpDevelop.
 * User: Kenneth Flores
 * Date: 09/03/2021
 * Time: 09:21 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

public class Chocolate : Menu {
		
	public int NoOrden { get; set; }
	
	public Chocolate(string nombre, string tipo, double precio, int noOrden){
		
		Nombre = nombre;
		Tipo = tipo;
		Precio = precio;
		NoOrden = noOrden;
		
	}
}