using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
    class Validaciones
    {
        
        Datos usuario = new Datos(); //Instancia Clase Datos metodo registros
        
        public void getRegistroCliente()
        {
           Console.WriteLine("***Registro de Clientes***");
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
        public void FacturacionSiNo()
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

