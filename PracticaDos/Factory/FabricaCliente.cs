using PracticaDos.Factory.Interfaces;
using PracticaDos.Factory.Menu;
using PracticaDos.Factory.Menu_Cliente;
using PracticaDos.Factory.Menu_Cliente._2da_Opcion_Cliente;
using PracticaDos.Factory.Menu_Cliente._3ra_Opcion__Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory
{
    internal class FabricaCliente
    {
        public static IMenuCliente menuCliente(int opcion)
        {
            if (opcion == 1) 
            {
                return new PrimeraOpcion();
            }
            if (opcion == 2)
            {
                return new SegundaOpcion();
            }
            if (opcion == 3)
            {
                return new TercceraOpcion();
            }
            else
            {
                return new ErrorMenuCliente();
            }


        }
    }
}
