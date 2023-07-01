using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    public class Datos //Almecena toda la información a consultar.
    {
       
        //Estado inicial de
        private string[] horario1 = new string[12];//Horarios                                          
        private string[] horario2 = new string[12];
        private string[] horario3 = new string[12];
        private string[] horario4 = new string[12];

        private string cliente1;//Clientes
        private string cliente2;
        private string cliente3;
        private string cliente4;
        private string cliente5;
        private string cliente6;
        private string cliente7;
        private string cliente8;
        private string cliente9;
        private string cliente10;

        public string[] cliente11 = new string[3];
        public string[] cliente12 = new string[3];

        private double tarifa;//Datos facturas
        private double iva;
        private double total;

        public Datos() //Constructor
        {
            cliente1 = " Roberto " + " Fernandez Esquivel " + " 101110222 " + " rfernandez @hotmail.com ";
            cliente2 = " Luisa " + " Herrera Perez " + " 202220222 " + " lherrera@gmail.com ";
            cliente3 = " Gabriel " + " Saenz Torres " + " 303330333 " + " gsaenz@yahoo.es ";
            cliente4 = " Daniel " + " Alvarez Solano " + " 404440444 " + " dalvarez@yahoo.com ";
            cliente5 = " Patricia " + " Sevilla Arias" + " 505550555 " + " psevilla25@gmail.com ";
            cliente6 = " Miguel " + " Mora Prado " + " 606660666 " + " mmora@rocketmail.com ";
            cliente7 = " Jorge " + " Salazar Arrieta " + " 707770777 " + " jsalazar88 @outlook.com";
            cliente8 = " Carolina " + " Arias Segura " + " 102210331 " + " carias@outlook.com ";
            cliente9 = " Silvia " + " Monge Lizano " + " 102220332 " + " smonge@hotmail.com ";
            cliente10 = " Sthepanie " + " Quesada Rojas " + " 102230333 " + " squesada17@gmail.com ";
            

            tarifa = 8000;
            iva = 0.16 * tarifa;
            total = tarifa + iva;
        }
        public string getFacturas()//metodo get que retorna información a mostrar en pantalla desde llamada en main
        {
            return "Cantidad--1 "+"Tarifa " + tarifa + "Impuesto " + iva + "Total" + total;
        }
        public void getRegistroCliente() //Llena el arreglo cliente11 con datos solicitados.
        {
            
            Console.WriteLine("***Registro de Clientes***");
            Console.WriteLine("Digite su nombre");
            cliente11[0] = Console.ReadLine();
            Console.WriteLine("Digite sus apellidos");
            cliente11[1] = Console.ReadLine();
            Console.WriteLine("Digite su cédula");
            cliente11[2] = Console.ReadLine();
            Console.WriteLine("Digite su dirección email");
            cliente11[3] = Console.ReadLine();


        }












    }

}