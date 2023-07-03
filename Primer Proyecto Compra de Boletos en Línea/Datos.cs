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

        public string[] cliente1 = { " Roberto ", " Fernandez Esquivel ", " 101110222 ", " rfernandez @hotmail.com " };
        public string[] cliente2 = { " Luisa " + " Herrera Perez " + " 202220222 " + " lherrera@gmail.com " };
        public string[] cliente3 = { " Gabriel " + " Saenz Torres " + " 303330333 " + " gsaenz@yahoo.es " };
        public string[] cliente4 = { " Daniel " + " Alvarez Solano " + " 404440444 " + " dalvarez@yahoo.com " };
        public string[] cliente5 = { " Patricia " + " Sevilla Arias" + " 505550555 " + " psevilla25@gmail.com " };
        public string[] cliente6 = { " Miguel " + " Mora Prado " + " 606660666 " + " mmora@rocketmail.com " };
        public string[] cliente7 = { " Jorge " + " Salazar Arrieta " + " 707770777 " + " jsalazar88 @outlook.com" };
        public string[] cliente8 = { " Carolina " + " Arias Segura " + " 102210331 " + " carias@outlook.com " };
        public string[] cliente9 = { " Silvia " + " Monge Lizano " + " 102220332 " + " smonge@hotmail.com " };
        public string[] cliente10 = { " Sthepanie " + " Quesada Rojas " + " 102230333 " + " squesada17@gmail.com " };

        private string[] cliente11 = new string[4];
        public string[] facturaCliente = new string[4];

        public double tarifa;
        public double iva;
        public double total;
        public string fecha;

        public string Fecha()
        {
            return fecha = DateTime.UtcNow.ToString("dd-MMM-yyyy");//Esatable fecha sin hora del sistema
        }
        public double Tarifa(double tarifa)
        {
            return tarifa = 8000;
        }
        public double Impuesto(double tarifa)
        {
           return iva = 0.16 * tarifa;
        }
        public double Total(double tarifa, double iva)
        {
         return total = tarifa + iva;
        }

        public string[] Cliente11(string[]cliente11)
        {
            return cliente11;
        }


            
        public void RegistroCliente()//Metodo que llena el arreglo cliente11, solicitando y validando datos al usuario
        {
            string decide= null;
         
            Console.WriteLine("Digite su nombre");
            cliente11[0] = Console.ReadLine();
            Console.WriteLine("Digite sus apellidos");
            cliente11[1] = Console.ReadLine();  
            Console.WriteLine("Digite su cedula");
            cliente11[2] = Console.ReadLine();
            Console.WriteLine("Digite su correo electronico");
            cliente11[3] = Console.ReadLine();
            Console.WriteLine("Desea Facturar SI(f)----NO(s)");
            if (decide == "f" || decide == "F")
            {
                DatosFactura();
            }
            if (decide == "s" || decide == "S")
            {
                Console.WriteLine("Hasta Luego");
            }

        }

          public void DatosFactura()//Metodo que obtiene datos realiza impresión informativa al usuario y pregunta si desea imprimir factura
          {
            char imprime;
            string[] tabla = { "Cantidad", "Descripción", "Fecha", "Pago" };
            Console.WriteLine($"{tabla[0],10} {tabla[1],8} {tabla[2],12} {tabla[3],10}");//Un pequeño arreglo que da orden a la tabla informativa
            Console.WriteLine($" 1           {cliente11[0],10}  {fecha,10}  {tarifa}");
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












    

