using PracticaDos.DecoracionEscritura;
using PracticaDos.Implementacion_Iniciar_Sesion;

namespace PracticaDos
{
    internal class Program
    {
        public static string JsonPath = @"Descargas\InformacionPracDos.json";
        public static string TxtLog = @"Descargas\InfoPracDos.txt";
        static void Main(string[] args)
        {
            if(!Directory.Exists("Descargas"))
            {
                Directory.CreateDirectory("Descargas");
            }

            if (!File.Exists(JsonPath))
                File.CreateText(JsonPath);

            if (!File.Exists(TxtLog))
                File.CreateText(TxtLog);

            EscrituraApp portadaApp = new EscrituraApp();
            portadaApp.DecoracionEscritura();
            InicioSesion inicioSesion = new InicioSesion();
            inicioSesion.inicioSesion();
            
        }
    }
}