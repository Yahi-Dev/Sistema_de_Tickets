using PracticaDos.ArchivoJson;
using PracticaDos.Clases_Esenciales;
using PracticaDos.Factory.Interfaces;
using PracticaDos.Factory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaDos.Factory.Menu;

namespace PracticaDos.Implementacion_Iniciar_Sesion
{
    internal class DecisionInicio
    {
        List<Usuario> usuarios = GuardarDatos.DeserializeJsonFile();
        public void Decision(string name, string password)
        {
            Usuario info = new Usuario();
            info.UserName = name;
            info.Password = password;
            if (password.Length > 0 && password[password.Length - 1] == '0')
            {
                info.Tipo = "Cliente";
            }
            if (password.Length > 0 && password[password.Length - 1] == '5')
            {
                info.Tipo = "Empleado";
            }
            if (password.Length > 0 && password[password.Length - 1] == '9')
            {
                info.Tipo = "Proveedor";
            }
            usuarios.Add(info);
            GuardarDatos.SerializeJsonFile(usuarios);
            IMenu menu = FabricaMenu.GetMenu(info.UserName, info.Password);
            menu.FabMenu(info.UserName);
        }
    }
}
