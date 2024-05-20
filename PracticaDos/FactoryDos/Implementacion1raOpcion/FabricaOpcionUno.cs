using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryDos.Implementacion1raOpcion
{
    internal class FabricaOpcionUno
    {
        public static IPrimeraOpcion_Opcion1 opcion1(int opcion)
        {
            if (opcion == 1)
            {
                return new Primera_opcion2();  
            }

            if (opcion == 2)
            {
                return new Segunda_Opcion2();
            }
            else 
            {
                return new ErrorPrimeraOpcionMenu();
            }
        }
    }
}
