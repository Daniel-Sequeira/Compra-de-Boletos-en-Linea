using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    public class Datos //Almecena toda la información a consultar.
    {

        //Estado inicial de arreglo Horarios
       
        public int[] horario1 = new int[3];
        public int[] horario2 = new int[3];
        public int[] horario3 = new int[3];
        public int[] horario4 = new int[3];

        string[] cliente1 = new string[4];
        string[] cliente2 = new string[4];
        string[] cliente3 = new string[4];
        string[] cliente4 = new string[4];
        string[] cliente5 = new string[4];
        string[] cliente6 = new string[4];
        string[] cliente7 = new string[4];
        string[] cliente8 = new string[4];
        string[] cliente9 = new string[4];
        string[] cliente10 = new string[4];

        public static string[] cliente11 = new string[4];
        //Factura
        public string[] facturaCliente = new string[4];

        //declaración variables que componen proceso de facturación
        public int tarifa;
        public double iva;
        public double total;



        public Datos() //(Muestra el estado inicial de las variables, si su valor se modifica cambia en todo el programa)
        {
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

            tarifa = 8000;
            iva = 0.16 * tarifa;
            total = tarifa + iva;
        }
         
        public void registroCliente()//Metodo que llena el arreglo cliente11, solicitando datos al usuario
        {
            string[] cliente11 = new string[4];
            Console.WriteLine("Digite su nombre");
            do
            {
                cliente11[0] = Console.ReadLine();
                if (string.IsNullOrEmpty(cliente11[0]))
                {
                    Console.WriteLine("Este campo no puede estar vacío. Por favor, intente nuevamente.");
                }
            }
            while (string.IsNullOrEmpty(cliente11[0]));
            Console.WriteLine("Digite sus apellidos");
            do
            {
                cliente11[1] = Console.ReadLine();
                if (string.IsNullOrEmpty(cliente11[1]))
                {
                    Console.WriteLine("Este campo no puede estar vacío. Por favor, intente nuevamente.");
                }
            }
            while (string.IsNullOrEmpty(cliente11[1]));
            Console.WriteLine("Digite su cedula");
            do
            {
                cliente11[2] = Console.ReadLine();
                if (string.IsNullOrEmpty(cliente11[2]))
                {
                    Console.WriteLine("Este campo no puede estar vacío. Por favor, intente nuevamente.");
                }
            }
            while (string.IsNullOrEmpty(cliente11[2]));
            Console.WriteLine("Digite su correo electronico");
            do
            {
                cliente11[3] = Console.ReadLine();
                if (string.IsNullOrEmpty(cliente11[3]))
                {
                    Console.WriteLine("Este campo no puede estar vacío. Por favor, intente nuevamente.");
                }
            }
            while (string.IsNullOrEmpty(cliente11[3]));

        
        }

        public void datosFactura()//Metodo que obtiene datos realiza impresión informativa al usuario y pregunta si desea imprimir factura
        {
            char imprime;
            string fecha = DateTime.UtcNow.ToString("dd-MMM-yyyy");//Esatable fecha sin hora del sistema
            string[] tabla = { "Cantidad", "Descripción", "Fecha", "Pago" };
            Console.WriteLine($"{tabla[0],10} {tabla[1],8} {tabla[2],12} {tabla[3],10}");//Un pequeño arreglo que da orden a la tabla informativa.
            Console.WriteLine($"   1         {cliente11[0],8}     {fecha,5}   {tarifa:c}");
            Console.WriteLine($"           { cliente11[1],5}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Subtotal  {tarifa:c}");//la sintaxis variable:c se refiere al formato de moneda (toma el del sistema)
            Console.WriteLine($"Impuesto   {iva:c}");
            Console.WriteLine($"Total     {total:c}"); 
            Console.WriteLine("");
            Console.WriteLine("Imprimir Factura? Si(g)//Salir(s)"); //Mostrará todos los clientes que viaja incluyendo el que ingresamos por teclado
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












    

