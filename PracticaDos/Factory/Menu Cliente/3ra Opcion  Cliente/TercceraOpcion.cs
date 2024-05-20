using PracticaDos.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory.Menu_Cliente._3ra_Opcion__Cliente
{
    internal class TercceraOpcion : IMenuCliente
    {
        public void FabCliente(string name)
        {
            Console.Clear();
            string problema = "                 Limpieza e higiene";
            Console.WriteLine(problema);
            Console.WriteLine("\n \n \n1- Baños sucios o desordenados");
            Console.WriteLine("\n2- Areas de la tienda desordenadas");
            Console.WriteLine("\n3- Productos expirados en estanderias");
            Console.Write("\n\nelija su opcion: ");
            int opcion = int.Parse(Console.ReadLine());
            I3RaOpcion i3RaOpcion = FabricaTres.opciones(opcion);
            i3RaOpcion.Fab3Opcion(name);
        }
    }
}
