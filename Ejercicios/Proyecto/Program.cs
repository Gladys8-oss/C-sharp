using System;

namespace Proyecto
{
    class Program
    {
        public enum Opciones {APERTURA_CUENTA = 1,
	               REGISTRO_DEPOSITO,
	               REGISTRO_RETIRO,
	               ESTADO_CUENTA,
	               TRANSFERIR_ENTRE_CUENTAS,
	               SALIR};
        static void Main(string[] args) 
        {
            
        Banco Bac = new Banco();
        String Opcion;
        do {
        Console.WriteLine ("       SISTEMA BANCARIO     \n");
        Console.WriteLine("\n1 - Apertura Cuenta\n");
        Console.WriteLine ("2 - Registrar Deposito\n");
        Console.WriteLine ("3 - Registrar Retiro\n");
        Console.WriteLine ("4 - Estado de Cuenta\n");
        Console.WriteLine ("5 - Transferir entre cuentas\n");
        Console.WriteLine ("6 - Salir\n");
        Console.WriteLine("-------------------------------\n");
        Console.WriteLine(" Seleccione opcion: ");
        Opcion = Console.ReadLine();

        switch (Opcion)
        {
            case "1" :
            Console.WriteLine("OPCION: Apertura Cuenta\n");
            Bac.aperturaCuenta();
            break;
            
            case "2":
            Console.WriteLine("OPCION: Registrar Deposito\n");
           // Bac.resgistrarDeposito();
            break;

            case "3":
            Console.WriteLine("OPCION: Registrar Retiro\n");
           // Bac.resgistrarRetiro();
            break;

            case "4":
            Console.WriteLine("OPCION: Estado de Cuenta\n");
           // Bac.estadoCuenta();
            break;

            case "5":
            Console.WriteLine("OPCION: Transferir entre cuentas\n");
            break;

            case "6": break;


            default:
            Console.WriteLine("* * ERROR - Opcion no existe\n");
            break;
        }
        }while  (Opcion != "6");
        }
     }
}
