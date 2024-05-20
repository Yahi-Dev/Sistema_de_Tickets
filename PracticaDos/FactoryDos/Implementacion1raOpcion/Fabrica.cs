using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryDos.Implementacion1raOpcion
{
    internal class Fabrica
    {
        public static I2daOpcionImplementacion i2DaOpcion(int opcion)
        {
            if (opcion == 1)
            {
                return new PrimeraOpcion_2daOpcion();
            }
            if (opcion == 2)
            {
                return new _2daOpcion_OpcionDos();
            }
            else
            {
                return new Error2daOpcionMenu();
            }
        }
    }
}
