﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {
        private const int V = 1;
        Datos horarios = new Datos(); //Instancia de la clase Datos metodo Horarios

        public void Menu ()
        {
          

           horarios.HorariosFerry(); //Muestra los horarios almacenados en arreglo horarios

            int opcion;

            Console.WriteLine("Elige tu horario con los números 1,2,3,4 o 5 para salir");//Titulo en pantalla
            opcion = Convert.ToInt32(Console.ReadLine());

            switch (opcion)
            {
                case (1):
                    Console.WriteLine("Elegiste el Horario 1"); //Debemos agregar codigo de l que sucede en cada opcion
                    break;
                case (2):
                    Console.WriteLine("Elegiste el Horario 2");
                    break;
                case (3):
                    Console.WriteLine("Elegiste el Horario 3");
                    break;
                case (4):
                    Console.WriteLine("Elegiste el Horario 4");
                    break;
                case (5):
                    Console.WriteLine("Fue un placer servirle, adiós");
                    break;

            }






        }

        public void Horario1()
        {

        }
    }
}
