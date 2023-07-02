using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {
        
        Datos factura = new Datos(); //Instancia Clase Datos metodo registros

        Datos horarios = new Datos();

        
        public void validarHorarios()
        {
            int[] comparador = {1,0,1};
            Random cualquiera = new Random();

            for (int i = 0; i < horarios.horario1.Length; i++)
            {
                horarios.horario1[i] = cualquiera.Next(0, 3);

                for (int j = 0; j < comparador.Length; j++)
                    if (comparador[j]== horarios.horario1[i])
                    {
                        Console.WriteLine("1---09:00h " + " Horario Lleno");
                    }
                    else Console.WriteLine("1---09:00h " + " Horario Disponible");
            }




            //Hacer lo mismo para cada horario

           /* for (int i = 0; i < horarios.horario2.Length; i++)
            { 
                horarios.horario2[i] = cualquiera.Next(0, 2);
            }
            for (int i = 0; i < horarios.horario3.Length; i++) 
            { 
                horarios.horario3[i] = cualquiera.Next(0, 2); 
            }
            for (int i = 0; i < horarios.horario4.Length; i++)
            {
                horarios.horario4[i] = cualquiera.Next(0, 2);
            }*/
         
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
                arreglo.datosFactura();
              
                    

            }

            else if (elegir == 's' || elegir == 'S') //Slida del programa si selecciona s o S
            {
                Console.WriteLine("Gracias vuelva pronto");
            }
            else
            {
                Console.WriteLine("Opción incorrecta");
            }

            
        }
       
    }
}

