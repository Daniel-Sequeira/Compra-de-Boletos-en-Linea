using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {


        Datos horarios = new Datos(); //Instancia de la clase Datos metodo Horarios


        public void getMenu()
        {
            bool continua = true;
            int opcion;
         
            do//ejecuta el siguiente código la primera vez
            {
                Console.WriteLine("Elige tu horario con los números 1,2,3,4 o 5 para salir");//Titulo en pantalla que verá el usuario
                string numero = Console.ReadLine(); //almacena la opción selecionada por usuario que será validada en adelante.

                if (int.TryParse(numero, out opcion)) //valida si es verdadero que el usuario digitó 1,2,3,4 o 5, de lo contrario Else.
                {
                    switch (opcion) //Realiza acciones de acuerdo a selección de usuario
                    {
                        case (1)://si usurio selecciona opcion 1 realizará
                            Console.Clear();//limpia la pantalla de datos 
                            Console.WriteLine("***Registro de Clientes***");
                            getRegistroCliente();//Llama al metodo de registro clientes
                            break;//detiene el ciclo

                        case (2)://si usuario selecciona opcion 2 realizará
                            Console.Clear();
                            Console.WriteLine("***Registro de Clientes***");
                            break;

                        case (3)://si usuario selecciona opcion 3 realizará
                            Console.Clear();
                            Console.WriteLine("***Registro de Clientes***");
                            break;

                        case (4)://si usuario selecciona opcion 4 realizará
                            Console.Clear();
                            Console.WriteLine("***Registro de Clientes***");

                            break;

                        case (5)://si usuario selecciona opcion 5 realizará
                            continua = false; //cambia el valor a falso entonces while no repite y sale

                            break;

                    }
                }
                else//Si el usuario digitó cualquier caracter fuera de opcion 1,2,3,4 o 5
                {
                    Console.WriteLine("Opcion invalida, digite 1,2,3,4 o 5 para salir");
                }

                Console.ReadKey();//Evita cierre 
            } while (continua);//Repite codigo de Do mientras siga siendo true (que el usuario no selleccione 5).


        }

        public void getRegistroCliente()
        {
            {
                Datos usuario = new Datos(); //Instancia Clase Datos metodo registros
                
                Console.WriteLine("Digite su nombre");
                usuario.cliente11[0] = Console.ReadLine();
                Console.WriteLine("Digite sus apellidos");
                usuario.cliente11[1] = Console.ReadLine();
                Console.WriteLine("Digite su cédula");
                usuario.cliente11[2] = Console.ReadLine();
                Console.WriteLine("Digite su dirección email");
                usuario.cliente11[3] = Console.ReadLine();
                Console.ReadKey();
                
            }

        }
        public void Facturacion()
        {
            char elegir;
            Console.WriteLine("Facturar digite (f) ///o (s) para Salir");
            elegir = Convert.ToChar(Console.ReadLine());

            if (elegir == 'f' || elegir == 'F')
            {
                Console.Clear();

                Console.WriteLine("Factura");
            }
            else if (elegir == 's' || elegir == 'S')
            {
                Console.WriteLine("No facatura");
            }
            else
            {
                Console.WriteLine("Opción inválida, para Facturar digite (f) ///o (s) para Salir");
            }
        }
    }
}

