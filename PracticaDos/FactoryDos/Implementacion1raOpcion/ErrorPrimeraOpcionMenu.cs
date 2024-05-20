using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryDos.Implementacion1raOpcion
{
    internal class ErrorPrimeraOpcionMenu : IPrimeraOpcion_Opcion1
    {
        public void Fab2daOpcion(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X ! X - ERROR - ELIJA UNA OPCION VALIDA EN EL MENU X ! X ");
            Console.WriteLine("\n \n \n                       Pulse Enter");
            Console.ReadKey();
            Console.ResetColor(); ;
            PrimeraOpcion_opcion2 primeraOpcion_Opcion2 = new PrimeraOpcion_opcion2();
            primeraOpcion_Opcion2.FabOpcion2(name);
        }
    }
}
