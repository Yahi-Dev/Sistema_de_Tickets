using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryDos.Implementacion1raOpcion
{
    internal class PrimeraOpcion_opcion2 : IPrimeraOpcion2
    {
        public void FabOpcion2(string name)
        {
            Console.Clear();
            Console.WriteLine("Seguridad en el Trabajo");


            Console.WriteLine("\n \n1- Equipos defectuosos");
            Console.WriteLine("\n2- Problemas de seguridad en el almacenamiento de productos");
            int opcion = int.Parse(Console.ReadLine());
            IPrimeraOpcion_Opcion1 primeraOpcion_Opcion1 = FabricaOpcionUno.opcion1(opcion);
            primeraOpcion_Opcion1.Fab2daOpcion(name);


        }
    }
}
