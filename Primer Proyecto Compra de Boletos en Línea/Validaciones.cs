using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {
        
        Datos factura = new Datos(); //Instancia Clase Datos metodo registros
        
        
        public void getFacturaSiNo()
        {
            char elegir;
            Console.WriteLine("Facturar digite (f) ///o (s) para Salir");
            elegir = Convert.ToChar(Console.ReadLine());

            if (elegir == 'f' || elegir == 'F')
            {
                Console.Clear();

                Console.WriteLine(factura.getFacturas());
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

