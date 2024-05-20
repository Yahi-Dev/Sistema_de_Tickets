using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryTres
{
    internal class FabricaProveedor
    {
        public static InterfaceProveedor Proveedor (int opcion)
        {
            if (opcion == 1) 
            {
                return new PrimeraOpcionProveesdor();            
            }
            if (opcion == 2)
            {
                return new _2OpcionProveedor();
            }
            if (opcion == 3)
            {
                return new _3opcionProveedor();
            }
            if (opcion == 4)
            {
                return new _4OpcionProveedor();
            }
            if (opcion == 5)
            {
                return new _5OpcionProveedor();
            }
            if (opcion == 6)
            {
                return new _6OpcionProveedorcs();
            }
            else
            {
                return new ErrorProveedor();
            }
        }
    }
}
