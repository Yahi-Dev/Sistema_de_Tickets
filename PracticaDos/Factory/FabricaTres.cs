using PracticaDos.Factory.Interfaces;
using PracticaDos.Factory.Menu_Cliente;
using PracticaDos.Factory.Menu_Cliente._3ra_Opcion__Cliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory
{
    internal class FabricaTres
    {
        public static I3RaOpcion opciones(int opcion)
        {
            if (opcion == 1)
            {
                return new PrimeraOpcion3();
            }
            if (opcion == 2)
            {
                return new SegundaOpcion3();
            }
            if (opcion == 3)
            {
                return new TerceraOpcion3();
            }
            else
            {
                return new Error3();
            }
        }
    }
}
