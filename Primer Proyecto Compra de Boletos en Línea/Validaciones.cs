using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {
        Datos horarios = new Datos(); //Instancia de la clase Datos metodo Horarios
        public void Menu ()
        {
           string opcion;

           horarios.HorariosFerry(); //Muestra los horarios almacenados en arreglo horarios a traves del llamado metodo
                                     //HorariosFerry
           Console.WriteLine("Elige tu horario con los números 1,2,3,4 o 5 para salir");//Titulo en pantalla
           opcion = Console.ReadLine();

            if (opcion == "1")
            {
                Console.WriteLine("Elegiste el horario de las 9:00 am");
            }
            

             
        }
    }
}
