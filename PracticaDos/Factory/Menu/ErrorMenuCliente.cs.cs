﻿using PracticaDos.Factory.Interfaces;
using PracticaDos.ImplementacionMenuCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory.Menu
{
    internal class ErrorMenuCliente : IMenuCliente
    {
        public void FabCliente(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X ! X - ERROR - ELIJA UNA OPCION VALIDA EN EL MENU X ! X ");
            Console.WriteLine("\n \n \n                       Pulse Enter");
            Console.ReadKey();
            Console.ResetColor();
            Implementacion menu = new Implementacion();
            menu.Menu(name);
        }
    }
}
