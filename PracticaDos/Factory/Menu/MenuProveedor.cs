using PracticaDos.Factory.Interfaces;
using PracticaDos.FactoryTres;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory.Menu
{
    internal class MenuProveedor : IMenu
    {
        public void FabMenu(string name)
        {
            MenuProvedor menuProvedor = new MenuProvedor();
            menuProvedor.Menuproveedor();
        }
    }
}
