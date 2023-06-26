using System;
using System.Collections.Generic;
using System.Text;

namespace Primer_Proyecto_Compra_de_Boletos_en_Línea
{
     public class Datos //Almecena toda la información a consultar.
    {
        private string[] horario1 = new string[0]; //intancia del arrego                                           
        private string[] horario2 = new string[0]; 
        private string[] horario3 = new string[0];
        private string[] horario4 = new string[0];

        public void HorariosFerry()
        {
            horario1 = new string[] { "09:00 am" };
            horario2 = new string[] { "12:00 pm" };
            horario3 = new string[] { "15:00 pm" };
            horario4 = new string[] { "20:00 pm" };

            Console.WriteLine("1---" + horario1[0]);
            Console.WriteLine("2---" + horario2[0]);
            Console.WriteLine("3---" + horario3[0]);
            Console.WriteLine("4---" + horario4[0]);
            Console.WriteLine("5---" + "Salir");
        }
        
    }
   


}
