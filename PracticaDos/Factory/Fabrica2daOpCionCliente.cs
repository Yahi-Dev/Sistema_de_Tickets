using PracticaDos.Factory.Interfaces;
using PracticaDos.Factory.Menu_Cliente;
using PracticaDos.Factory.Menu_Cliente._2da_Opcion_Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory
{
    internal class Fabrica2daOpCionCliente
    {
        public static I2daOpcion opcion(int opcion)
        {
            if (opcion == 1)
            {
                return new PrimerraOpcionCliente();
            }
            if (opcion == 2)
            {
                return new SegundaOpcionClientecs();
            }
            if (opcion == 3)
            {
                return new TerceraOpcionCliente();
            }
            else
            {
                return new Error2daOpcion();
            }
        }
    }
}
