using System;
using System.Text.RegularExpressions;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {
        Datos horarios = new Datos();//Instancia de clase datos para acceder a arreglos desde Clase validaciones



        public void ValidarHorarios()//Método que establece si horario está lleno o no aleatoriamente.
        {
            int[] comparador = { 1,0,1 };//Arreglo que almacena datos tipo entero utilizado para comparaciones.
            Random cualquiera = new Random();// El metodo Rqandom genera numeros aleatorios 
            bool horarioNodisponible;//Variable de condición true o false
          
            for (int i = 0; i < horarios.horario1.Length; i++)//Bucle For recorre los indices del arreglo horario 1 uno a uno
            {
                horarios.horario1[i] = cualquiera.Next(0, 2);//Rellena los indices con numeros aleatorios 0 incluido 2 excluido

                if (comparador[1] == horarios.horario1[1] ) //Comparación de indices [1] entre arreglos según coincidencia o no determina la impresión
                {                                          // Horario LLeno o Disponible
                    Console.WriteLine("1---09:00h " + " Horario Lleno");
                    horarioNodisponible = false;//Si el horario está Lleno la variable toma condición de false con idea de reducir condicion de LLeno o disponible valores booleanos.

                    if (horarioNodisponible)
                    {
                        Console.WriteLine("Este horario está lleno, seleccione otro");                  
                    }
                    break;//Sale del ciclo.
                }
                else
                {
                    Console.WriteLine("1---09:00h " + "Horario Disponible");//de no cumplirse lo anterior el horario está disponible (true)
                    horarioNodisponible = true;

                    break;
                }
                
            }
                                //El siguiente código realiza las comparaciones como descritas anteriormente.

            bool horarioNodisponible2;
            for (int i = 0; i < horarios.horario2.Length; i++)
            {
                horarios.horario2[i] = cualquiera.Next(0, 2);
               
                if (comparador[0] == horarios.horario1[2] )
                {
                    Console.WriteLine("2---12:00h " + " Horario Lleno");
                    horarioNodisponible2 = false;
                    if (horarioNodisponible2)
                    {
                        Console.WriteLine("Este horario está lleno, seleccione otro");
                       
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("2---12:00h  " + "Horario Disponible");
                    horarioNodisponible = true;
                    break;

                }
                
            }

      
            bool horarioNodisponible3;
            for (int i = 0; i < horarios.horario3.Length; i++)
            {
                horarios.horario3[i] = cualquiera.Next(0, 2);
                
                if (comparador[0] == horarios.horario1[0])
                {
                    Console.WriteLine("3---15:00h  " + " Horario Lleno");
                    horarioNodisponible3 = false;
                    if (horarioNodisponible3)
                    {
                        Console.WriteLine("Este horario está lleno, seleccione otro");
                        
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("3---15:00h " + "Horario Disponible");
                    horarioNodisponible3 = true;
                    break;
                }
                
            }


                 bool horarioNodisponible4;
            for (int i = 0; i < horarios.horario4.Length; i++)
            {
                
                horarios.horario4[i] = cualquiera.Next(0, 2);
               
                if (comparador[1] == horarios.horario1[0])
                {
                    Console.WriteLine("4---20:00h " + " Horario Lleno");
                    horarioNodisponible4 = false;
                    if (horarioNodisponible4)
                    {
                        Console.WriteLine("Este horario está lleno, seleccione otro");
                      
                    }
                    break;
                }
                else
                {
                    Console.WriteLine("4---20:00h " + "Horario Disponible");
                    horarioNodisponible = true;
                    break;
                }

                
            }
       
            Console.WriteLine("5---Salir");//Imprime en pantalla opción de salida

        }


        public void PreguntaSiNo()//El metodo que valida si el usuario desea facturar, obteniendo datos de facturacion (cliente incluido por teclado)

        {
            char elegir;//Variable que almacena valor ingresado por teclado por el usuario.

            Console.WriteLine("Facturar digite (f) ///o (s) para Salir");//Imprime en pantalla si desea facturar
            elegir = Convert.ToChar(Console.ReadLine()); //Almacena valor ingresado por teclado por el usuario.

            if (elegir == 'f' || elegir == 'F') //Condicional if establece true con f mayuscula o minuscula y ejecuta el código
            {
                Datos arreglo = new Datos();
                Console.Clear();
                Console.WriteLine("/////////Facturación/////////");
                Console.WriteLine("");//Espacio en blanco
                arreglo.DatosFactura();//Muestra los títulos del formato de la factura almacenados en arreglo DatosFactura



            }

            else if (elegir == 's' || elegir == 'S') //Salida del programa si selecciona s o S
            {
                Environment.Exit(0); //Sale del programa
            }
            else
            {
                Console.WriteLine("Opción incorrecta");
            }


        }

        public static bool ValidarCedula(string cedula) // El metodo que valida si el usuario ingresa de manera correcta su cedula
        {
            string patron = @"^\d{9}$";//Define una variable llamada patron que contiene una expresión regular (cadena de 9 digitos)
            return Regex.IsMatch(cedula, patron);//Método IsMatch de la clase Regex valida si la cadena de texto almacenada en la variable cedula 
        }                                        //coincide con el patrón definido anteriormente.

        public static bool ValidarEmail(string email) // El metodo que valida si el usuario ingresa de manera correcta su correo
        {
            string patron = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"; //La expresión regular @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$"valida si cadena coincide con formato dirección email.
            return Regex.IsMatch(email, patron);//verificar si la cadena de texto almacenada en la variable email coincide con el patrón definido anteriormente.
        }



    }
}

