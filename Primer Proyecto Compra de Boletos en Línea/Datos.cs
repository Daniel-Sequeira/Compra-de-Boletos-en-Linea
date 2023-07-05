using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    public class Datos //Almecena toda la información a consultar.
    {


        //Inicialización de arreglos y variables
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
        //Los métodos publicos se pueden consultar des fuera de esta clase.
        public string Fecha()//Método string con retorno (donde se llame a ejecución devolverá fecha)
        {
            return fecha = DateTime.UtcNow.ToString("dd-MMM-yyyy");//Esatable fecha sin hora del sistema
        }
        public double Tarifa()//Método tipo double con retorno (tarifa)
        {
            return tarifa = 8000;
        }
        public double Impuesto()//Método tipo double con retorno (RESULTADO DE CALCULAR IMPUESTO 16%)
        {
            return iva = 0.16 * tarifa;
        }
        public double Total()//Método tipo double con retorno (RESULTADO TARIFA + IVA)
        {
            return total = (tarifa + iva);
        }
        public string Cliente11() //Método string devuelve contenido de los indices de arreglo
        {
            return cliente11[0] +" "+ cliente11[1] + " " + cliente11[2] + " " + cliente11[3];
        }
        private void ClientesExiten()//Asignación de valor a los arreglos clientes existentes.
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

            Console.WriteLine("Digite su nombre"); //Texto que verá usuario en pantalla.
            do//ciclo do ejecuta el código una vez y repite segun condición while
            {
                cliente11[0] = Console.ReadLine();//Almacena datos ingresados por teclado en indice 0 de arreglo cliente11
                if (string.IsNullOrEmpty(cliente11[0]))// Mediante el metodo(string.IsNullOrEmpty()) determina si una string está vacía o nula, si está vacia 
                {                                      //devuelve true si no false
                    Console.WriteLine("Este campo no puede estar vacio, por favor intente de nuevo");//Si es true imprime el mensaje en pantalla
                }
            } while (string.IsNullOrEmpty(cliente11[0]));//si devuelve true (espacio vacío) repite el codigo

            Console.WriteLine("Digite sus apellidos");//Texto que verá usuario en pantalla.
            do
            {
                cliente11[1] = Console.ReadLine(); //Almacena datos ingresados por teclado en indice 1 de arreglo cliente11
                if (string.IsNullOrEmpty(cliente11[1]))
                {
                    Console.WriteLine("Este campo no puede estar vacio, por favor intente de nuevo");//(MISMO PROCESO Y METODO QUE EL ANTERIOR)
                }
            } while (string.IsNullOrEmpty(cliente11[1]));

            Console.WriteLine("Digite su cedula de identidad");//Texto que verá usuario en pantalla.
            do
            {
                cliente11[2] = Console.ReadLine();//Almacena datos ingresados por teclado en indice 2 de arreglo cliente11
                if (string.IsNullOrEmpty(cliente11[2]))
                {
                    Console.WriteLine("Este campo no puede estar vacio");
                }
                else if (!Validaciones.ValidarCedula(cliente11[2]))
                {
                    Console.WriteLine("Formato invalido, debe contener 9 digitos, intente de nuevo");
                }
            } while (string.IsNullOrEmpty(cliente11[2]) || !Validaciones.ValidarCedula(cliente11[2]));

            Console.WriteLine("Digite su correo electronico");//Texto que verá usuario en pantalla.
            do
            {
                cliente11[3] = Console.ReadLine();//Almacena datos ingresados por teclado en indice 3 de arreglo cliente11
                if (string.IsNullOrEmpty(cliente11[3]))
                {
                    Console.WriteLine("Este campo no puede estar vacio, por favor intente de nuevo");
                }
                else if (!Validaciones.ValidarEmail(cliente11[3]))
                {
                    Console.WriteLine("Formato de correo electronico incorrecto");
                }
            } while (string.IsNullOrEmpty(cliente11[3]) || !Validaciones.ValidarEmail(cliente11[3]));


            string decide; //variable que almacena la desición sobre si usuario desea facturar o no
            do// ciclo do ejecuta el codigo una vez mientras (while) no sea afirmativo de lo contrario se sobre entiende que el usuario no desea facturar
            {    // por tanto al elegir salir sale del programa.
                Console.Clear();
                Console.WriteLine("Desea Facturar SI(f)----NO(s)");//Texto que verá usuario en pantalla.

                decide = Console.ReadLine();

                if (decide == "f" || decide == "F")
                {
                    DatosFactura();
                }
                if (decide == "s" || decide == "S")
                {
                    Environment.Exit(0);
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
            imprime = Console.ReadLine(); //variable imprime almacena la desición del usuario ingresada por teclado
            do//ciclo do while inicia proceso
            {
                if (imprime == "g" || imprime == "G")//si la respuesta es afirmativa limpia la pantalla
                {
                    Console.Clear();
                    Console.WriteLine("     Los que viajan Puntarenas---Paquera    ");//Imprime título en pantalla
                    ClientesExiten();//Invoca metodo que almace arreglos de clientes existentes

                    foreach (string item in cliente1) //EL bucle Foreach recorre cada elemento en arreglo cliente1. 
                    {                                 //En cada iteración del bucle, la variable item toma el valor del elemento actual en el indice leído 
                        Console.WriteLine(item);     //y se ejecuta el código dentro del bloque del bucle (imprime el valor de la variable item).
                                                     // por tanto se imprime el arrrglo y así con los siguientes.
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
                    Environment.Exit(0);//Salida del programa
                    break;
                }
            } while (imprime != "s" || imprime != "S");

    

            


            
        }
    }   
        
}












    

