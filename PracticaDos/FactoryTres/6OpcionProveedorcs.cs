using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryTres
{
    internal class _6OpcionProveedorcs : InterfaceProveedor
    {
        public void FabProveedor()
        {
            Console.Clear();
            string ficha = ("CALIDAD DE LOS PRODUCTOS");
            Console.WriteLine(ficha);

            Console.Write("\n \nNombre: ");
            string nombreReporte = Console.ReadLine();
            Console.Write("\nTelefono: ");
            string numero = Console.ReadLine();


            Console.WriteLine(" \n \nElija la itencidad del problema \n\nAlta prioridad.\n Media prioridad.\n Baja prioridad.");
            Console.Write("\nComo considera usted el grado de esta incidencia: ");

            string tipoIncidencia = Console.ReadLine();
            Console.Write("\n \nEscriba una observacion para tomarla en cuenta: ");
            string observacion = Console.ReadLine();
            Logger.Logger.Instance.Log(ficha, nombreReporte, numero, tipoIncidencia, observacion);
            for (int i = 0; i < 130; i++)
            {
                Console.Write("-");
                Thread.Sleep(10);
            }
            Console.WriteLine("Realizado...");
            Thread.Sleep(3000);

            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GRACIAS POR SU REPORTE :) ");
            Console.WriteLine("\n \n Pulse Enter ");
            Console.ReadKey();
            Console.ResetColor();
            MenuProvedor menuProvedor = new MenuProvedor();
            menuProvedor.Menuproveedor();
        }
    }
}
