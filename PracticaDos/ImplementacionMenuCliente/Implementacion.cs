using PracticaDos.Factory;
using PracticaDos.Factory.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.ImplementacionMenuCliente
{
    internal class Implementacion
    {
        public void Menu(string username)
        {
            try {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Bienvenido al Departamento de quejas de la Farmacia");
                Thread.Sleep(2000);
                Console.Clear();
                Console.WriteLine("                                                                                                            cliente...\n \n \n    ");
                Console.WriteLine("                                     Menu");
                Console.WriteLine("\n \n \n1- Problemas con medicamentos");
                Console.WriteLine("\n2- Servicio al cliente");
                Console.WriteLine("\n3- Limpieza e higiene");

                Console.Write("\nIndique su opcion: ");
                int opcion = int.Parse(Console.ReadLine());


                IMenuCliente menuCliente = FabricaCliente.menuCliente(opcion);
                menuCliente.FabCliente(username);

               
            } catch (Exception e) 
            {
                  
            }
            
        }
    }
}
