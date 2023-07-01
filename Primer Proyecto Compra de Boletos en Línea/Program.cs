using System;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Program
    {
        
        static void Main(string[] args)//Main es lo primero que llama y ejecuta el programa.
        {
            Console.WriteLine("////// Horarios Ferry Puntarenas---Paquera//////");//Titulo en pantalla que verá el usuario

            Console.WriteLine("1------09:00 am");
            Console.WriteLine("2------12:00 pm");
            Console.WriteLine("3------15:00 pm");
            Console.WriteLine("4------20:00 pm");
            Console.WriteLine("5------Salir");
            
            bool continua = true;
            int opcion;

            do//ejecuta el siguiente código la primera vez
            {
                Console.WriteLine("Elige tu horario con los números 1,2,3,4 o 5 para salir");//Titulo en pantalla que verá el usuario
                string numero = Console.ReadLine(); //almacena la opción selecionada por usuario que será validada en adelante.

                if (int.TryParse(numero, out opcion)) //valida si es verdadero que el usuario digitó 1,2,3,4 o 5, de lo contrario Else.
                {
                    Validaciones registro = new Validaciones();
                    switch (opcion) //Realiza acciones de acuerdo a selección de usuario
                    {
                        case (1)://si usurio selecciona opcion 1 realizará
                            Console.Clear();//limpia la pantalla de datos 
                            
                            registro.getRegistroCliente();//Llama al metodo de registro clientes
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
     



















    }
    
}
