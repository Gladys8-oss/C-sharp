using System;
class Login 
{
    public void user() {
		
		
		string opcion = "";
		
		Console.WriteLine("SISTEMA - POO");
		Console.WriteLine("");
		Console.WriteLine("1 - Admin");	
		opcion = Console.ReadLine();
		
		switch ( opcion ) {
				
			case "1": 
		
				Console.WriteLine("Ingrese su usuario: ");
				string usuario = Console.ReadLine();
				Console.WriteLine("Ingrese la contraseña: ");
				string password = Console.ReadLine();
				Console.Clear();
				
				if ( usuario == "Admin" && password == "123456" || usuario == "Gladys" && password == "123") {
					Console.WriteLine("Bienvenido al Sistema" + usuario);
				// bool ingresa = true;
				}
				break;
			
			default:
            Console.WriteLine("Ingrese una opcion valida: ");
			break;
				
		  }
      
   } 
}