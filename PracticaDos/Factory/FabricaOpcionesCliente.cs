using PracticaDos.Factory.Interfaces;
using PracticaDos.Factory.Menu_Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory
{
    internal class FabricaOpcionesCliente
    {
        public static IOpcionesCliente Opciones(int opcion)
        {
            if (opcion == 1)
            {
                return new ImplementacionPrimeraOpcion();
            }
            if (opcion == 2)
            {
                return new ImplementacionSegundaOpcionCliente();
            }
            if (opcion == 3)
            {
                return new ImplementacionTerceraOpcionCliente();
            }
            else
            {
                return new ErrorCliente();
            }
        }

    }
}
