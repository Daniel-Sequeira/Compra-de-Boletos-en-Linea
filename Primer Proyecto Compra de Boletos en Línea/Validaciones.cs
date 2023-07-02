using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {
        
        Datos factura = new Datos(); //Instancia Clase Datos metodo registros
        
        
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
                Console.WriteLine("Falta codigo de salida");
            }
            else
            {

            }

            
        }
    }
}

