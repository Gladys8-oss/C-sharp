/*
 * Created by SharpDevelop.
 * User: Kenneth Flores
 * Date: 17/03/2021
 * Time: 01:07 a.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

public class CafeTender : Persona {
	
	public int CodigoCafeTender { get; set; }
	
	public CafeTender (string nombre, string apellido, string telefono, int codigoCafeTender)
	
	{
		
		Nombre = nombre;
		Apellido = apellido;
		Telefono = telefono;
		CodigoCafeTender = codigoCafeTender;
		
	}

}