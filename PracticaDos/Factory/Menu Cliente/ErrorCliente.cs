using PracticaDos.Factory.Interfaces;
using PracticaDos.ImplementacionMenuCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory.Menu_Cliente
{
    internal class ErrorCliente : IOpcionesCliente
    {
        public void FabOpcionesCliente(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X ! X - ERROR - ELIJA UNA OPCION VALIDA EN EL MENU X ! X ");
            Console.WriteLine("\n \n \n                       Pulse Enter");
            Console.ReadKey();
            Console.ResetColor();
            PrimeraOpcion primeraOpcion = new PrimeraOpcion();
            primeraOpcion.FabCliente(name);


        }
    }
}
