using System;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Program
    {
        static void Main(string[] args)
        {
            ///Este es el Main del cual llamamos los métodos o clases
            Datos horariosFerry = new Datos(); //Instancia de la clase Datos metodo Horarios

            Console.WriteLine("Horarios Ferry Puntarenas---Paquera");//Titulo en pantalla que verá el usuario
            Console.WriteLine(horariosFerry.Horarios());//Llamada de Clase Datos y Metodo Horarios
            //Se debe hacer un arreglo mientras estoy probando que la llamda fincione (borrar esto al terminar)
           
            


        }
    }
}
