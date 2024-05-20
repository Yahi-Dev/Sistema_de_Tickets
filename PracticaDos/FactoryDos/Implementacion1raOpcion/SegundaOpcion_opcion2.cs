using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaDos.FactoryDos.Implementacion1raOpcion
{
    internal class SegundaOpcion_opcion2 : IPrimeraOpcion2
    {
        public void FabOpcion2(string name)
        {
            Console.Clear();
            Console.WriteLine("Recursos Humanos");


            Console.WriteLine("\n \n1- Acoso laboral");
            Console.WriteLine("\n2- Discriminacion");
            int opcion = int.Parse(Console.ReadLine());
            I2daOpcionImplementacion implementacion = Fabrica.i2DaOpcion(opcion);
            implementacion.Fab2da_2(name);
        }
    }
}
