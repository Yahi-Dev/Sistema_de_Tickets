using PracticaDos.Factory.Interfaces;
using PracticaDos.Factory.Menu;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.Factory.Menu_Cliente
{
    internal class PrimeraOpcion : IMenuCliente
    {
        public void FabCliente(string name)
        {
            int opcion;
            do
            {
                Console.Clear();
                string problema = "                 Problemas con medicamentos";
                Console.WriteLine(problema);
                Console.WriteLine("\n \n \n1- Entrega de medicamentos incorrectos");
                Console.WriteLine("\n2- Medicamentos vencidos");
                Console.WriteLine("\n3- reacciones adversas a medicamentos");
                Console.Write("\n\nelija su opcion: ");
                opcion = int.Parse(Console.ReadLine());
                IOpcionesCliente opcionesCliente = FabricaOpcionesCliente.Opciones(opcion);
                opcionesCliente.FabOpcionesCliente(name);

                try
                {
                    opcion = int.Parse(Console.ReadLine()!);
                }catch 
                {
                    opcion = 4;
                }

            } while (opcion >= 4 || opcion <= 0);
        }
    }
}
