using PracticaDos.ArchivoJson;
using PracticaDos.Clases_Esenciales;
using PracticaDos.ArchivoJson;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PracticaDos.Factory.Interfaces;
using PracticaDos.Factory;

namespace PracticaDos.Implementacion_Iniciar_Sesion
{
    internal class InicioSesion
    {
        public void inicioSesion()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(@" ____ ____ ____ ____ ____ ____ _________ ____ ____ 
||I |||N |||I |||C |||I |||O |||       |||D |||E ||
||__|||__|||__|||__|||__|||__|||_______|||__|||__||
|/__\|/__\|/__\|/__\|/__\|/__\|/_______\|/__\|/__\|
 ____ ____ ____ ____ ____ ____ _________ _________ 
||S |||E |||S |||I |||O |||N |||       |||       ||
||__|||__|||__|||__|||__|||__|||_______|||_______||
|/__\|/__\|/__\|/__\|/__\|/__\|/_______\|/_______\|");

            Console.Write("\n \n \n \n \nUSERNAME: ");
            string name = Console.ReadLine();
            Console.Write("\nPASSWORD: ");
            string password = Console.ReadLine();
            DecisionInicio decisionInicio = new DecisionInicio();
            decisionInicio.Decision(name, password);
        }
    }
}
