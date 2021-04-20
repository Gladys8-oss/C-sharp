/*
 * Created by SharpDevelop.
 * User: Kenneth Flores
 * Date: 09/03/2021
 * Time: 09:17 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

public class Te : Menu {
	
	public int NoOrden { get; set; }
	
	public Te (string nombre, string tipo, double precio, int noOrden){
		
		Nombre = nombre;
		Tipo = tipo;
		Precio = precio;
		NoOrden = noOrden;
		
	}
}