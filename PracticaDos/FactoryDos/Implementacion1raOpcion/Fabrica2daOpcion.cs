using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryDos.Implementacion1raOpcion
{
    internal class Fabrica2daOpcion
    {
        public static IPrimeraOpcion2 opcion2(int opcion)
        {
            if (opcion == 1) 
            {
                return new PrimeraOpcion_opcion2();
            }
            if (opcion == 2)
            {
                return new SegundaOpcion_opcion2();
            }
            else
            {
                return new ErrorOpcionDos_Menu();
            }

        }
    }
}
