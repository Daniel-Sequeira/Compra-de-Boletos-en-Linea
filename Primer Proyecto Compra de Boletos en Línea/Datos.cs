using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    public class Datos //Almecena toda la información a consultar.
    {


        //Estado inicial de arreglo Horarios
        public int[] horario1 = new int[3];
        public int[] horario2 = new int[3];
        public int[] horario3 = new int[3];
        public int[] horario4 = new int[3];

        private string[] cliente1 = new string[4];
        private string[] cliente2 = new string[4];
        private string[] cliente3 = new string[4];
        private string[] cliente4 = new string[4];
        private string[] cliente5 = new string[4];
        private string[] cliente6 = new string[4];
        private string[] cliente7 = new string[4];
        private string[] cliente8 = new string[4];
        private string[] cliente9 = new string[4];
        private string[] cliente10 = new string[4];

        public string[] cliente11 = new string[4];
        public string[] facturaCliente = new string[4];

        private double tarifa;
        private double iva;
        private double total;
        private string fecha;

        public string Fecha()
        {
            return fecha = DateTime.UtcNow.ToString("dd-MMM-yyyy");//Esatable fecha sin hora del sistema
        }
        public double Tarifa()
        {
            return tarifa = 8000;
        }
        public double Impuesto()
        {
            return iva = 0.16 * tarifa;
        }
        public double Total()
        {
            return total = (tarifa + iva);
        }
        public string Cliente11()
        {
            return cliente11[0] +" "+ cliente11[1] + " " + cliente11[2] + " " + cliente11[3];
        }
        private void ClientesExiten()
        {
            cliente1 = new string[] { " Roberto "+ " Fernandez Esquivel "+ " 101110222 "+ " rfernandez @hotmail.com " };
            cliente2 = new string[] { " Luisa " + " Herrera Perez " + " 202220222 " + " lherrera@gmail.com " };
            cliente3 = new string[] { " Gabriel " + " Saenz Torres " + " 303330333 " + " gsaenz@yahoo.es " };
            cliente4 = new string[] { " Daniel " + " Alvarez Solano " + " 404440444 " + " dalvarez@yahoo.com " };
            cliente5 = new string[] { " Patricia " + " Sevilla Arias" + " 505550555 " + " psevilla25@gmail.com " };
            cliente6 = new string[] { " Miguel " + " Mora Prado " + " 606660666 " + " mmora@rocketmail.com " };
            cliente7 = new string[] { " Jorge " + " Salazar Arrieta " + " 707770777 " + " jsalazar88 @outlook.com" };
            cliente8 = new string[] { " Carolina " + " Arias Segura " + " 102210331 " + " carias@outlook.com " };
            cliente9 = new string[] { " Silvia " + " Monge Lizano " + " 102220332 " + " smonge@hotmail.com " };
            cliente10 = new string[] { " Sthepanie " + " Quesada Rojas " + " 102230333 " + " squesada17@gmail.com " };
           

        }



        public void RegistroCliente()//Metodo que llena el arreglo cliente11, solicitando y validando datos al usuario
        {


            Console.WriteLine("Digite su nombre");
            cliente11[0] = Console.ReadLine();
            Console.WriteLine("Digite sus apellidos");
            cliente11[1] = Console.ReadLine();
            Console.WriteLine("Digite su cedula");
            cliente11[2] = Console.ReadLine();
            Console.WriteLine("Digite su correo electronico");
            cliente11[3] = Console.ReadLine();
            string decide;
            do
            {
                Console.Clear();
                Console.WriteLine("Desea Facturar SI(f)----NO(s)");
               
                decide = Console.ReadLine();

                if (decide == "f" || decide == "F")
                {
                    DatosFactura();
                }
                if (decide == "s" || decide == "F")
                {
                    Console.WriteLine("Hasta Luego");
                    break;
                }

            } while (decide != "f" || decide != "F");
        }




        public void DatosFactura()//Metodo que obtiene datos realiza impresión informativa al usuario y pregunta si desea imprimir factura
        {
            string imprime;
            string[] tabla = { "Cantidad", "Descripción", "Fecha", "Pago" };
            Console.WriteLine($"{tabla[0],10} {tabla[1],8} {tabla[2],12} {tabla[3],10}");//Un pequeño arreglo que da orden a la tabla informativa
            Console.WriteLine($"  1          {cliente11[0],10}  {Fecha(),10}  {Tarifa():C}");
            Console.WriteLine($"            {cliente11[1],10}");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine($"Subtotal  {Tarifa():C}");//la sintaxis variable:c se refiere al formato de moneda (toma el del sistema)
            Console.WriteLine($"Impuesto   {Impuesto():c}");
            Console.WriteLine($"Total     {Total():c}");
            Console.WriteLine("");
            Console.WriteLine("Imprimir Factura? Si(g)//Salir(s)"); //Mostrará todos los clientes que viaja incluyendo el que ingresamos por teclado
            imprime = Console.ReadLine();
            do
            {
                if (imprime == "g" || imprime == "G")
                {
                    Console.Clear();
                    Console.WriteLine("     Los que viajan Puntarenas---Paquera    ");
                    ClientesExiten();

                    foreach (string item in cliente1)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in cliente2)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in cliente3)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in cliente4)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in cliente5)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in cliente6)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in cliente6)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in cliente7)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in cliente8)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in cliente9)
                    {
                        Console.WriteLine(item);
                    }
                    foreach (string item in cliente10)
                    {
                        Console.WriteLine(item);
                    }
                    Console.WriteLine(Cliente11());
                    Console.ReadKey();


                }
                if (imprime == "s" || imprime == "S")
                {
                    Console.WriteLine("Regresarás a Menú Principal");
                    break;
                }
            } while (imprime != "s");

    {

            }


            
        }
    }   
        
}












    

