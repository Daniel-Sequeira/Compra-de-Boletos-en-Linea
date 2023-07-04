using System;
using System.Text.RegularExpressions;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {
        Datos horarios = new Datos();



        public void ValidarHorarios()
        {
            int[] comparador = { 1,0,2 };
            Random cualquiera = new Random();
            bool horarioNodisponible = false;

            for (int i = 0; i < horarios.horario1.Length; i++)
            {
                horarios.horario1[i] = cualquiera.Next(0, 3);

                for (int j = 0; j < comparador.Length; j++)
                {
                    if (comparador[0] == horarios.horario1[2] && !horarioNodisponible)
                    {
                        Console.WriteLine("1---09:00h " + " Horario Lleno");
                        horarioNodisponible = true;
                    }
                }
            }
            if (!horarioNodisponible)
            {
                Console.WriteLine("1---09:00h " + "Horario Disponible");
            }

            bool horarioNodisponible2 = false;
            for (int i = 0; i < horarios.horario2.Length; i++)
            {
                horarios.horario2[i] = cualquiera.Next(0, 2);
                for (int j = 0; j < comparador.Length; j++)
                {
                    if (comparador[0] == horarios.horario1[1] && !horarioNodisponible2)
                    {
                        Console.WriteLine("2---12:00h " + " Horario Lleno");
                        horarioNodisponible2 = true;
                    }
                }
            }
            if (!horarioNodisponible2)
            {
                Console.WriteLine("2---12:00h  " + "Horario Disponible");
            }

            bool horarioNodisponible3 = false;
            for (int i = 0; i < horarios.horario3.Length; i++)
            {
                horarios.horario3[i] = cualquiera.Next(0, 2);
                for (int j = 0; j < comparador.Length; j++)
                {
                    if (comparador[1] == horarios.horario1[1] && !horarioNodisponible3)
                    {
                        Console.WriteLine("3---15:00h  " + " Horario Lleno");
                        horarioNodisponible3 = true;
                    }
                }
            }
            if (!horarioNodisponible3)
            {
                Console.WriteLine("3---15:00h " + "Horario Disponible");
            }

            bool horarioNodisponible4 = false;
            for (int i = 0; i < horarios.horario4.Length; i++)
            {
                horarios.horario4[i] = cualquiera.Next(0, 2);
                for (int j = 0; j < comparador.Length; j++)
                {
                    if (comparador[0] == horarios.horario1[0] && !horarioNodisponible4)
                    {
                        Console.WriteLine("4---20:00h " + " Horario Lleno");
                        horarioNodisponible4 = true;
                    }
                }
            }
            if (!horarioNodisponible4)
            {
                Console.WriteLine("4---20:00h " + "Horario Disponible");
            }

            Console.WriteLine("5---Salir");

        }


        public void PreguntaSiNo()//el metodo que valida si el usuario desea facturar, obteniendo datos de facturacion (cliente incluido por teclado)

        {
            char elegir;

            Console.WriteLine("Facturar digite (f) ///o (s) para Salir");
            elegir = Convert.ToChar(Console.ReadLine());

            if (elegir == 'f' || elegir == 'F') //establece true con f mayuscula o minuscula y ejecuta el código
            {
                Datos arreglo = new Datos();
                Console.Clear();
                Console.WriteLine("/////////Facturación/////////");
                Console.WriteLine("");
                arreglo.DatosFactura();



            }

            else if (elegir == 's' || elegir == 'S') //Salida del programa si selecciona s o S
            {
                Console.WriteLine("Gracias vuelva pronto");
            }
            else
            {
                Console.WriteLine("Opción incorrecta");
            }


        }

        public static bool ValidarCedula(string cedula) // El metodo que valida si el usuario ingresa de manera correcta su cedula
        {
            string patron = @"^\d{9}$";
            return Regex.IsMatch(cedula, patron);
        }

        public static bool ValidarEmail(string email) // El metodo que valida si el usuario ingresa de manera correcta su correo
        {
            string patron = @"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$";
            return Regex.IsMatch(email, patron);
        }



    }
}

