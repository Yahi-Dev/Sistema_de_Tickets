using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace PracticaDos.FactoryDos.Implementacion1raOpcion
{
    internal class Error2daOpcionMenu : I2daOpcionImplementacion
    {
        public void Fab2da_2(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X ! X - ERROR - ELIJA UNA OPCION VALIDA EN EL MENU X ! X ");
            Console.WriteLine("\n \n \n                       Pulse Enter");
            Console.ReadKey();
            Console.ResetColor();
            SegundaOpcion_opcion2 segundaOpcion_Opcion2 = new SegundaOpcion_opcion2();
            segundaOpcion_Opcion2.FabOpcion2(name);
        }
    }
}
