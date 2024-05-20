using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryDos.Implementacion1raOpcion
{
    internal class ErrorOpcionDos_Menu : IPrimeraOpcion2
    {
        public void FabOpcion2(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X ! X - ERROR - ELIJA UNA OPCION VALIDA EN EL MENU X ! X ");
            Console.WriteLine("\n \n \n                       Pulse Enter");
            Console.ReadKey();
            Console.ResetColor();
            Menu2daOpcion menu2DaOpcion = new Menu2daOpcion();
            menu2DaOpcion.Menu2DaPpcion(name);
        }
    }
}
