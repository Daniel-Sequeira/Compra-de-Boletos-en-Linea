using System;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Program
    {
        static void Main(string[] args)//Main es lo primero que llama y ejecuta el programa.
        {
            Validaciones MenuPrincipal = new Validaciones(); //Instancia de la clase validaciones  
           
            Console.WriteLine("////// Horarios Ferry Puntarenas---Paquera//////");//Titulo en pantalla que verá el usuario

            Console.WriteLine("1------09:00 am");
            Console.WriteLine("2------12:00 pm");
            Console.WriteLine("3------15:00 pm");
            Console.WriteLine("4------20:00 pm");
            Console.WriteLine("5------Salir");
            MenuPrincipal.getMenu(); //llamada al metodo que contiene menu principal y opciones.
           

           






            


       


            
          
           
            


        }
    }
}
