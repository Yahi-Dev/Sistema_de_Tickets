using PracticaDos.Factory.Interfaces;
using PracticaDos.FactoryDos.Implementacion1raOpcion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryDos
{
    internal class Menu2daOpcion
    {
        public void Menu2DaPpcion(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("                                                                                                EMPLEADO");
            Console.WriteLine("MENU");
            Console.WriteLine("\n \n \n1- Seguridad en el Trabajo");
            Console.WriteLine("\n2- Recursos Humanos");
            Console.Write("\nElija una opcion: ");
            int opcion = int.Parse(Console.ReadLine());
            IPrimeraOpcion2 opcion1 = Fabrica2daOpcion.opcion2(opcion);
            opcion1.FabOpcion2(name);

        }
    }
}
