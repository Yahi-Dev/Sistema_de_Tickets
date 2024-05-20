using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryTres
{
    internal class MenuProvedor
    {
        public void Menuproveedor()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("               MENU");
            Console.WriteLine("\n \n \n \n1- Entrega de Productos Incorrectos \n2- Retrasos en las Entregas \n3- Productos Dañados o Caducados \n4- Problemas de Comunicación \n5- Facturación y Pagos \n6- Calidad de los Productos ");
            int opcion = int.Parse(Console.ReadLine());
            InterfaceProveedor interfaceProveedor = FabricaProveedor.Proveedor(opcion);
            interfaceProveedor.FabProveedor();
        }
    }
}
