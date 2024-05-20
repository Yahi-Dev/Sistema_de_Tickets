using PracticaDos.Factory.Interfaces;
using PracticaDos.Implementacion_Iniciar_Sesion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory.Menu
{
    internal class Error : IMenu
    {
        public void FabMenu(string name)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("X ! X SUS CREDENCIALES SON INCORRECTAS - POR FAVOR COMUNIQUESE CON NUESTRO CENTRO X ! X \n \nPulse Enter");
            Console.ResetColor();
            Console.ReadKey();
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.inicioSesion();

        }
    }
}
