using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {
        
        Datos factura = new Datos(); //Instancia Clase Datos metodo registros

        Datos horarios = new Datos();

        
        public void validarHorarios()
        {
            int[] comparador = {1,0,1};
            Random cualquiera = new Random();
            bool horarioNodisponible = false;

            for (int i = 0; i < horarios.horario1.Length; i++)
            {
                horarios.horario1[i] = cualquiera.Next(0, 3);

                for (int j = 0; j < comparador.Length; j++)
                {
                    if (comparador[0] == horarios.horario1[0] && !horarioNodisponible)
                    {
                        Console.WriteLine("1---09:00h " + " Horario Lleno");
                        horarioNodisponible = true;
                    }
                }
            }
            if (!horarioNodisponible)
            {
                Console.WriteLine("1---09:00h " + "Horario Dispoible");
            }

            bool horarioNodisponible2 = false;
            for (int i = 0; i < horarios.horario2.Length; i++)
            { 
                horarios.horario2[i] = cualquiera.Next(0, 2);
                for (int j = 0; j < comparador.Length; j++)
                {
                    if (comparador[0] == horarios.horario1[1] && !horarioNodisponible2)
                    {
                        Console.WriteLine("2---12:00h " + " Horario Lleno");
                        horarioNodisponible2 = true;
                    }
                }
            }
            if (!horarioNodisponible2)
            {
                Console.WriteLine("2---12:00h  " + "Horario Dispoible");
            }

            bool horarioNodisponible3 = false;
            for (int i = 0; i < horarios.horario3.Length; i++) 
            { 
                horarios.horario3[i] = cualquiera.Next(0, 2);
                for (int j = 0; j < comparador.Length; j++)
                {
                    if (comparador[0] == horarios.horario1[1] && !horarioNodisponible3)
                    {
                        Console.WriteLine("3---15:00h  " + " Horario Lleno");
                        horarioNodisponible3 = true;
                    }
                }
            }
            if (!horarioNodisponible3)
            {
                Console.WriteLine("3---15:00h " + "Horario Dispoible");
            }

            bool horarioNodisponible4 = false;
            for (int i = 0; i < horarios.horario4.Length; i++)
            {
                horarios.horario4[i] = cualquiera.Next(0, 2);
                for (int j = 0; j < comparador.Length; j++)
                {
                    if (comparador[0] == horarios.horario1[0] && !horarioNodisponible4)
                    {
                        Console.WriteLine("4---20:00h " + " Horario Lleno");
                        horarioNodisponible4 = true;
                    }
                }
            }
            if (!horarioNodisponible4)
            {
                Console.WriteLine("4---20:00h " + "Horario Dispoible");
            }

            Console.WriteLine("5---Salir");

        }
          

            public void PreguntaSiNo()//el metodo que valida si el usuario desea facturar, obteniendo datos de facturacion (cliente incluido por teclado)
        {
            char elegir;
           
            Console.WriteLine("Facturar digite (f) ///o (s) para Salir");
            elegir = Convert.ToChar(Console.ReadLine());

            if (elegir == 'f' || elegir == 'F') //establece true con f mayuscula o minuscula y ejecuta el código
            {
                Datos arreglo = new Datos();
                Console.Clear();
                Console.WriteLine("/////////Facturación/////////");
                Console.WriteLine("");
                arreglo.datosFactura();
              
                    

            }

            else if (elegir == 's' || elegir == 'S') //Salida del programa si selecciona s o S
            {
                Console.WriteLine("Gracias vuelva pronto");
            }
            else
            {
                Console.WriteLine("Opción incorrecta");
            }

            
        }
       
    }
}

