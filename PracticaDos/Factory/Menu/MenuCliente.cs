using PracticaDos.Factory.Interfaces;
using PracticaDos.Factory.Menu_Cliente;
using PracticaDos.ImplementacionMenuCliente;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory.Menu
{
    class MenuCliente : IMenu
    {
        public void FabMenu(string name)
        {
           Implementacion implementacion = new Implementacion();
            implementacion.Menu(name);
        }
    }
}
