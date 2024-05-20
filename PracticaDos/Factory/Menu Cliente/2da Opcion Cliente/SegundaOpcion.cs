using PracticaDos.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticaDos.Factory.Menu_Cliente._2da_Opcion_Cliente
{
    internal class SegundaOpcion : IMenuCliente
    {
        public void FabCliente(string name)
        {
            try
            {
                Console.Clear();
                string problema = "                 Servicio al Cliente";
                Console.WriteLine(problema);
                Console.WriteLine("\n \n \n1- Tiempo de espera");
                Console.WriteLine("\n2- Personal poco amable o poco servicial");
                Console.WriteLine("\n3- Falta de disponibilidad de prodcutos");
                Console.Write("\n\nelija su opcion: ");
                int opcion = int.Parse(Console.ReadLine());
                I2daOpcion i2DaOpcion = Fabrica2daOpCionCliente.opcion(opcion);
                i2DaOpcion.Fab2daOpcion(name);
            }
            catch (Exception ex)
            {

            }
        }
    }
}
