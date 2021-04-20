using System;
class Banco
{
    private	int indiceCuenta;
    public string nombre { get; set; }

    public string identidad  { get; set; }

    public string telefono  { get; set; }

   public string direccion  { get; set; }

   public string correo  { get; set; }

   public double saldoInicial { get; set; }

   public double debitos { get; set; }

   public double credito { get; set; }

   public double MONTO_PERMITIDO { get; set; }

   public double SALDO_MINIMO  { get; set; }

   public int MAX_CUENTAS { get; set; }

   public int NO_EXISTE { get; set; }

    public Banco () { //Constructor
		indiceCuenta = 0;

        SALDO_MINIMO = 500.00;

        MONTO_PERMITIDO = 30000.01;

        MAX_CUENTAS = 3;

        NO_EXISTE =-1;
	}

    void pedirDatosAperturaCuenta(int noCuenta) 
	{
		//numeroCuenta = noCuenta;
		//cin.ignore(100, '\n');
	// registrar los demas dato del proprietario
	Console.WriteLine("Nombre : " );
	nombre =Console.ReadLine();
	Console.ReadLine();
	Console.WriteLine("Identidad : " );
    identidad = Console.ReadLine() ;
	Console.WriteLine( "Numero de telefono : " );
    telefono = Console.ReadLine();
	Console.WriteLine("Direccion : " );
	direccion = Console.ReadLine();
	Console.WriteLine( "Correo electronico: " );
	correo = Console.ReadLine();
		
		bool esCorecto;
		do 
		{
			
				Console.WriteLine("Saldo Inicial:  " );
                string saldoi = "";
                saldoInicial = Convert.ToInt32(saldoi);
			   saldoi= Console.ReadLine();
				if (saldoInicial < SALDO_MINIMO || !esAceptadoMonto(saldoInicial))
				{
					esCorecto = false;
					if (!esAceptadoMonto(saldoInicial)){
						Console.WriteLine( "* * ERROR no se permite una Apertura con un " + "Saldo suprior a L." + MONTO_PERMITIDO );
					}
					else
					{
						Console.WriteLine("* * ERROR no se permite una Apertura con un " +
					    "Saldo inferior a L." + SALDO_MINIMO);
					}
						
				}
				
				else 
				{
					esCorecto = true;
				}

		} while (esCorecto == false);
		
	}
  // SIGUIENTES LINEAS

  bool esAceptadoMonto(double monto) {
		return (monto <= MONTO_PERMITIDO);
	}

	int buscarPorNumeroCuenta(int numeroCuenta1) {
	    int indice = NO_EXISTE;
		for (int i=0; i<indiceCuenta ; i++) {
			if (numeroCuenta1 == numeroCuenta1) {
				indice = i; // Aqui salvamos el indice donde se encontro la cuenta.
				break;  // terminamos la ejecucion del for.
			}
		}
		return indice;
	}
    	public void aperturaCuenta () {
		//Vamos a verficar que no se exceda del limite de cuentas
		// que estan en el arreglo
		if (indiceCuenta < MAX_CUENTAS) {
			int numeroCuenta;
		    Console.WriteLine( "ingrese numero de cuenta: ");
            string nocuentas ="";
            numeroCuenta = Convert.ToInt32(nocuentas);
            nocuentas = Console.ReadLine();
			if (buscarPorNumeroCuenta(numeroCuenta) == NO_EXISTE) {
		    pedirDatosAperturaCuenta(numeroCuenta);
		    indiceCuenta++;
			} else {
				Console.WriteLine("* * ERROR -  Numero de cuenta ya existe.\n");
				//system("PAUSE");
			}
		} else {
		    Console.WriteLine( "* * ERROR - Se ha llegado al limite de las cuentas. \n");
		}
	}
}