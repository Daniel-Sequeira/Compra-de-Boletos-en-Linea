using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    public class Datos //Almecena toda la información a consultar.
    {
        private string[] horario1 = new string[0]; //Declaración de arreglos                                           
        private string[] horario2 = new string[0];
        private string[] horario3 = new string[0];
        private string[] horario4 = new string[0];

        private string[] cliente1 = new string[3];
        private string[] cliente2 = new string[3];
        private string[] cliente3 = new string[3];
        private string[] cliente4 = new string[3];
        private string[] cliente5 = new string[3];
        private string[] cliente6 = new string[3];
        private string[] cliente7 = new string[3];
        private string[] cliente8 = new string[3];
        private string[] cliente9 = new string[3];
        private string[] cliente10 = new string[3];
        private string[] cliente11 = new string[3];
        private string[] cliente12 = new string[3];

        private string[] factura1 = new string[4];
        private string[] factura2 = new string[4];


        public void HorariosFerry()
        {
            horario1 = new string[] { "09:00 am" };
            horario2 = new string[] { "12:00 pm" };
            horario3 = new string[] { "15:00 pm" };
            horario4 = new string[] { "20:00 pm" };

            Console.WriteLine("1---" + horario1[0]);
            Console.WriteLine("2---" + horario2[0]);
            Console.WriteLine("3---" + horario3[0]);
            Console.WriteLine("4---" + horario4[0]);
            Console.WriteLine("5---" + "Salir");



        }
        public void ClientesFerry()
        {

            cliente1 = new string[] { " Roberto " + " Fernandez Esquivel " + " 101110222 " + " rfernandez@hotmail.com " };
            cliente2 = new string[] { " Luisa " + " Herrera Perez " + " 202220222 " + " lherrera@gmail.com " };
            cliente3 = new string[] { " Gabriel " + " Saenz Torres " + " 303330333 " + " gsaenz@yahoo.es " };
            cliente4 = new string[] { " Daniel " + " Alvarez Solano " + " 404440444 " + " dalvarez@yahoo.com" };
            cliente5 = new string[] { " Patricia " + " Sevilla Arias" + " 505550555 " + " psevilla25@gmail.com " };
            cliente6 = new string[] { " Miguel " + " Mora Prado " + " 606660666 " + " mmora@rocketmail.com " };
            cliente7 = new string[] { " Jorge " + " Salazar Arrieta " + " 707770777 " + " jsalazar88@outlook.com " };
            cliente8 = new string[] { " Carolina " + " Arias Segura " + " 102210331 " + " carias@outlook.com " };
            cliente9 = new string[] { " Silvia " + " Monge Lizano " + " 102220332 " + " smonge@hotmail.com " };
            cliente10 = new string[] { " Sthepanie " + " Quesada Rojas " + " 102230333 " + " squesada17@gmail.com " };

            cliente11 = new string[] { };
            Console.WriteLine("Digite su nombre");
            cliente11[0] = Console.ReadLine();
            Console.WriteLine("Digite sus apellidos");
            cliente11[1] = Console.ReadLine();
            Console.WriteLine("Digite su cédula");
            cliente11[2] = Console.ReadLine();
            Console.WriteLine("Digite su dirección email");
            cliente11[3] = Console.ReadLine();

            cliente12 = new string[] { };
            Console.WriteLine("Digite su nombre");
            cliente12[0] = Console.ReadLine();
            Console.WriteLine("Digite sus apellidos");
            cliente12[1] = Console.ReadLine();
            Console.WriteLine("Digite su cédula");
            cliente12[2] = Console.ReadLine();
            Console.WriteLine("Digite su dirección email");
            cliente12[3] = Console.ReadLine();


            foreach  (string muestraInfo1 in cliente1)
            {
                Console.WriteLine(muestraInfo1 + " ");
            }
            foreach (string muestraInfo2 in cliente2)
            {
                Console.WriteLine(muestraInfo2 + " ");
            }
            foreach (string muestraInfo3 in cliente3)
            {
                Console.WriteLine(muestraInfo3 + " ");
            }
            foreach (string muestraInfo4 in cliente4)
            {
                Console.WriteLine(muestraInfo4 + " ");
            }
            foreach (string muestraInfo5 in cliente5)
            {
                Console.WriteLine(muestraInfo5 + " ");
            }
            foreach (string muestraInfo6 in cliente6)
            {
                Console.WriteLine(muestraInfo6 + " ");
            }
            foreach (string muestraInfo7 in cliente7)
            {
                Console.WriteLine(muestraInfo7 + " ");
            }
            foreach (string muestraInfo8 in cliente8)
            {
                Console.WriteLine(muestraInfo8 + " ");
            }
            foreach (string muestraInfo9 in cliente9)
            {
                Console.WriteLine(muestraInfo9 + " ");
            }
            foreach (string muestraInfo10 in cliente10)
            {
                Console.WriteLine(muestraInfo10 + " ");
            }
            foreach (string muestraInfo11 in cliente11)
            {
                Console.WriteLine(muestraInfo11 + " ");
            }
            foreach (string muestraInfo12 in cliente12)
            {
                Console.WriteLine(muestraInfo12 + " ");
            }

            /*public void TarifaFerry()
          {

              int tarifa = 8000;
              double iva = tarifa * 0.16;
              double total = tarifa + iva;
          }

          public string Facturas()
          {
              return
              cliente11[0] + cliente11[1];

          }*/

        }



    }
}