/*
 * Created by SharpDevelop.
 * User: Kenneth Flores
 * Date: 23/03/2021
 * Time: 05:01 p.m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */

using System;

public class Login {
	
	
	public void user() {
		
		
		string opcion = "";
		
		//while (true) {
		Console.WriteLine("CAFE PATAGOTIAN");
		Console.WriteLine("");
		Console.WriteLine("1 - Admin");
		Console.WriteLine("2 - User");
		Console.WriteLine("3 - Salir");
		
		opcion = Console.ReadLine();
		
		switch ( opcion ) {
				
			case "1": 
		
				Console.WriteLine("Ingrese su usuario: ");
				string usuario = Console.ReadLine();
				Console.WriteLine("Ingrese la contraseña: ");
				string password = Console.ReadLine();
				Console.Clear();
				
				if ( usuario == "Admin" && password == "123456" ) {
					Console.WriteLine("Bienvenido al Sistema" + usuario);
				
				} else if (usuario == "Gladys" && password =="123")
				{
					Console.WriteLine("Bienvenido al Sistema" + usuario);
				}
				break;	
			default:
				break;
				
		}
		
		/*	if (opcion == "3") {
				break;
			}
		}*/
	}
}