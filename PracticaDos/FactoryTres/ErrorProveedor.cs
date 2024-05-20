using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryTres
{
    internal class ErrorProveedor : InterfaceProveedor
    {
        public void FabProveedor()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X ! X - ERROR - ELIJA UNA OPCION VALIDA EN EL MENU X ! X ");
            Console.WriteLine("\n \n \n                       Pulse Enter");
            Console.ReadKey();
            Console.ResetColor();
            MenuProvedor menuProveedor = new MenuProvedor();
            menuProveedor.Menuproveedor();
        }
    }
}
