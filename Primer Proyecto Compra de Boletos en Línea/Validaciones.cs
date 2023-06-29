using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {

        private const int V = 1;
        Datos horarios = new Datos(); //Instancia de la clase Datos metodo Horarios
        Datos registro = new Datos();

        public void Menu()
        {

            horarios.HorariosFerry(); //Muestra los horarios almacenados en arreglo horarios
            bool continua = true;
            do
            {
                int opcion;

                Console.WriteLine("Elige tu horario con los números 1,2,3,4 o 5 para salir");//Titulo en pantalla
                string numero = Console.ReadLine();

                if (int.TryParse(numero, out opcion))
                {
                    switch (opcion)
                    {
                        case (1):
                            Console.Clear();
                            Console.WriteLine("***Registro de Clientes***");
                            RegistroCliente();
                           
                            break;
                        case (2):
                            Console.Clear();
                            Console.WriteLine("***Registro de Clientes***");
                            RegistroCliente();
                            break;
                        case (3):
                            Console.Clear();
                            Console.WriteLine("***Registro de Clientes***");
                            RegistroCliente();
                            break;
                        case (4):
                            Console.Clear();
                            Console.WriteLine("***Registro de Clientes***");
                            RegistroCliente();
                            break;
                        case (5):
                            continua = false;

                            break;

                    }
                }
                else
                {
                    Console.WriteLine("Opcion invalida, digite 1,2,3,4 o 5 para salir");
                }


                Console.ReadKey();
            } while (continua);


        }
        public void RegistroCliente()
        {
            registro.RegistroC11();
           

        }

        public void Facturar()
        { }         
            
    }

}

