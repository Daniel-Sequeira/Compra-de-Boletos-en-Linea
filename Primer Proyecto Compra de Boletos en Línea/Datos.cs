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
        //Clientes
        string[] cliente1 = { " Roberto ", " Fernandez Esquivel ", " 101110222 ", " rfernandez @hotmail.com " };
        string[] cliente2 = { " Luisa " + " Herrera Perez " + " 202220222 " + " lherrera@gmail.com " };
        string[] cliente3 = { " Gabriel " + " Saenz Torres " + " 303330333 " + " gsaenz@yahoo.es " };
        string[] cliente4 = { " Daniel " + " Alvarez Solano " + " 404440444 " + " dalvarez@yahoo.com " };
        string[] cliente5 = { " Patricia " + " Sevilla Arias" + " 505550555 " + " psevilla25@gmail.com " };
        string[] cliente6 = { " Miguel " + " Mora Prado " + " 606660666 " + " mmora@rocketmail.com " };
        string[] cliente7 = { " Jorge " + " Salazar Arrieta " + " 707770777 " + " jsalazar88 @outlook.com" };
        string[] cliente8 = { " Carolina " + " Arias Segura " + " 102210331 " + " carias@outlook.com " };
        string[] cliente9 = { " Silvia " + " Monge Lizano " + " 102220332 " + " smonge@hotmail.com " };
        string[] cliente10 = { " Sthepanie " + " Quesada Rojas " + " 102230333 " + " squesada17@gmail.com " };

        public static string[] cliente11 = new string[4];
        public string[] facturaCliente = new string[4];
        

        public int tarifa;
        public double iva;
        public double total;



        public Datos() //Constructor
        {
            tarifa = 8000;
            iva = 0.16 * tarifa;
            total = tarifa + iva;
            
            
        }
        public void registroCliente()
        {

            Console.WriteLine("Digite su nombre");
            cliente11[0] = Console.ReadLine();
            Console.WriteLine("Digite sus apellidos");
            cliente11[1] = Console.ReadLine();
            Console.WriteLine("Digite su cédula");
            cliente11[2] = Console.ReadLine();
            Console.WriteLine("Digite su dirección email");
            cliente11[3] = Console.ReadLine();
        }

        public void datosFactura()
        {
            char imprime;
            string fecha = DateTime.UtcNow.ToString("dd-MMM-yyyy");
            string[] tabla = { "Cantidad", "Descripción", "Fecha", "Pago" };
            Console.WriteLine($"{tabla[0],10} {tabla[1],8} {tabla[2],12} {tabla[3],10}");
            Console.WriteLine($"   1         {cliente11[0],8}     {fecha,5}   {tarifa:c}");
            Console.WriteLine($"           { cliente11[1],5}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Subtotal  {tarifa:c}");
            Console.WriteLine($"Impuesto   {iva:c}");
            Console.WriteLine($"Total     {total:c}"); 
            Console.WriteLine("");
            Console.WriteLine("Imprimir Factura? Si(g)//Salir(s)");
            imprime = Convert.ToChar(Console.ReadLine());
            if (imprime == 'g' || imprime == 'G')
            {
                Console.Clear();
            }
            else if (imprime == 's' || imprime == 'S')
            {
                Console.Clear();
            }
        }
    }
}












    

