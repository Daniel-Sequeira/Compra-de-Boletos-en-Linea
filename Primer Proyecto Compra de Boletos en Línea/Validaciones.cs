using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {
        
        Datos horarios = new Datos();


        public void ValidarHorarios()
        {
            int[] comparador = { 1, 0, 1 };
            Random cualquiera = new Random();
            bool horarioNodisponible = false;

            for (int i = 0; i < horarios.horario1.Length; i++)
            {
                horarios.horario1[i] = cualquiera.Next(0, 3);

                for (int j = 0; j < comparador.Length; j++)
                {
                    if (comparador[0] == horarios.horario1[2] && !horarioNodisponible)
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
                    if (comparador[1] == horarios.horario1[1] && !horarioNodisponible3)
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
                arreglo.DatosFactura();
              
                    

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
        public void GuardaFactura()
        {
            Datos arreglofac = new Datos();
            Datos arregloclient = new Datos();
            Console.WriteLine("");
            Console.WriteLine("Imprimir Factura? Si(g)//Salir(s)"); //Mostrará todos los clientes que viaja incluyendo el que ingresamos por teclado
             string imprime = Console.ReadLine();
            if (imprime == "g" || imprime == "G")
            {
                Console.Clear();
                for (int i = 0; i < arreglofac.facturaCliente.Length; i++)
                {
                    arreglofac.facturaCliente[0] = "1";
                    arreglofac.facturaCliente[1] = arregloclient.cliente11[1] + arregloclient.cliente11[2];
                    arreglofac.facturaCliente[2] = arreglofac.fecha;
                    arreglofac.facturaCliente[3] = Convert.ToString(arreglofac.total);
                }
                
            }
            else if (imprime == "s" || imprime == "S")
            {
                
            }


        }


    }
}

