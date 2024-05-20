using PracticaDos.Factory.Interfaces;
using PracticaDos.FactoryDos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory.Menu
{
    internal class MenuEmpleado : IMenu
    {
        public void FabMenu(string name)
        {
            Menu2daOpcion menu2DaOpcion = new Menu2daOpcion();
            menu2DaOpcion.Menu2DaPpcion(name);
        }
    }
}
