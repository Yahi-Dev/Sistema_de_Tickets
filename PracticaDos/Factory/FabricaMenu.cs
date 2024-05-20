using PracticaDos.Clases_Esenciales;
using PracticaDos.Factory.Interfaces;
using PracticaDos.Factory.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory
{
    internal class FabricaMenu
    {
        public static IMenu GetMenu(string userName, string password)
        {
            if (password.Length  > 0 && password[password.Length - 1] == '0')
            {
                return new MenuCliente();
    
            }
            if (password.Length > 0 && password[password.Length - 1] == '5')
            {
                return new MenuEmpleado();

            }
            if (password.Length > 0 && password[password.Length - 1] == '9')
            {
                return new MenuProveedor();

            }
            else
            {
                return new Error();
            }
        }
    }
}
