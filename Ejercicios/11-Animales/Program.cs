using System;

namespace _11_Animales
{
    class Program
    {
        static void Main(string[] args)
        {
          Perro p = new Perro();
          Console.WriteLine("Menu animales");
          Console.WriteLine("1. Mamiferos");
          Console.WriteLine("2. Vertebrados");
          Console.WriteLine("Ingrese una Opcion del menu");
          string Opcion = Console.ReadLine();
          while (true)
          {

          switch (Opcion)
          {
            case "1":
            Console.WriteLine("Mamiferos");
            Console.WriteLine("1. Perros ");
            Console.WriteLine("2. Gatos");
            Console.WriteLine("3. Monos");
            Console.WriteLine("1. Ingrese una Opcion");
            string Op1 = Console.ReadLine();
            switch (Op1)
            {
                case "1":
            p.Nombre = "Susi";
            p.Patas =2;
            p.Domestico = true;
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Tamano();
            Console.WriteLine("El Nombre del Perro es: " + p.Nombre);
            Console.WriteLine("Tiene : " + p.Patas + "Patas");
            Console.WriteLine("Es Domestico : " + p.Domestico);
                break;
            
            case "2":
          Gato g = new Gato();
          g.Nombre = "Bonita";
          g.Patas =4;
          g.Comer();
          g.Maullar();
          g.Domestico = true; 

          Console.WriteLine("El Nombre del Gato es: " + g.Nombre);
          Console.WriteLine("Tiene : " + g.Patas + "Patas");
          Console.WriteLine("Es Domestico : " + g.Domestico);
            break;

            case "3":
            Mono m = new Mono();
            m.Nombre = "Lucy";
            m.Extremidades = 4;
            m.Domestico = false;
            m.Comer();
          Console.WriteLine("El Nombre del Mono es: " + m.Nombre);
          Console.WriteLine("Tiene : " + m.Extremidades + "Extremidades");
          Console.WriteLine("Es Domestico : " + m.Domestico);
            break;

                default:
                Console.WriteLine("Ingrese una Opcion valida");
                break;
            }
            break;
            //Vertebradoss

            case "2":
            Console.WriteLine("*****Vertebrados******");
            Console.WriteLine("1. Aves");
            Console.WriteLine("2. Peces");
            string Opc2 = Console.ReadLine();
            switch (Opc2)
            {
                case "1":
            Console.WriteLine("1. Aguila");
            Console.WriteLine("2. Loro");
            Console.WriteLine("Ingrese una Opcion");
            string Opc3 =  Console.ReadLine();
            switch (Opc3)
            {
                case "1":
                Aguila a = new Aguila();
                a.Nombreave = "Águila Real";
                a.LongitudAlas = 2;
                a.Velocidad = 160;
                a.Domestico = false;
                a.Patas = 2;
                a.Pelaje = "si";

            Console.WriteLine("El Nombre del Aguila es: " + a.Nombreave);
            Console.WriteLine("Longitud de las alas : " + a.LongitudAlas  + " Metros");
            Console.WriteLine("Velocidad: " + a.Velocidad + " Km/h");
            Console.WriteLine("Tiene Pelaje: " + a.Pelaje);
            Console.WriteLine("Es Domestico : " + a.Domestico);
            a.VolarAlto();
                break;

                case "2":
                Loro l = new Loro();
                l.Nombreave = "Cacatúa";
                l.Domestico = true;
                l.Longitud = 33;
                l.Patas = 2;
                l.Pelaje = "si";
                   
            Console.WriteLine("El Nombre del Loro es: " + l.Nombreave);
            Console.WriteLine("Longitud de las alas : " + l.Longitud  + " Centimetros");
            Console.WriteLine("Tiene : " + l.Velocidad + " Patas");
            Console.WriteLine("Tiene Pelaje : " + l.Pelaje );
            Console.WriteLine("Es Domestico : " + l.Domestico);
                break;

                default:
                Console.WriteLine("Ingrese una opcion valida");
                break;
            }
                break;

                case "2":
                // peces
                PezGlobo pg = new PezGlobo();
                pg.Nombre = "Pez Globo";
                pg.Domestico = false;
                pg.Familia = "Tetraodontidae; Bonaparte, 1831";
                pg.Reino = "Animalia";
                pg.Clase = "Actinopterygii";
                pg.Orden= "Tetraodontiformes";

            Console.WriteLine("Nombre del Pez : " + pg.Nombre );
            Console.WriteLine("Familia : " + pg.Familia);
            Console.WriteLine("Reino : " + pg.Reino);
            Console.WriteLine("Clase : " + pg.Clase);
            Console.WriteLine("Orden: " + pg.Orden);
            Console.WriteLine("Domestico : " + pg.Domestico);
                break;
                default:
                Console.WriteLine("Ingrese una Opcion Valida");
                break;
            }
            break;
            //Terminacion de vertebrados
          default:
          break;
          }
          if (Opcion == "0")
          {
          break;
          }    
        }
        } 
    }
}
