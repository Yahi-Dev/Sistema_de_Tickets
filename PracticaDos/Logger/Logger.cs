using PracticaDos.Logger;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace PracticaDos.Logger
{
    public sealed class Logger
    {
        private static Logger instance;
        private readonly string LogFilePath;

        private Logger(string logFilePath)
        {
            this.LogFilePath = logFilePath;
        }

        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    string logFilePath = Program.TxtLog;
                    instance = new Logger(logFilePath);
                }
                return instance;
            }
        }

        public void Log(string ficha, string nombre, string telefono, string prioridad, string observacion)
        {
            string logEntry = $@"
Tipo de tickets: {ficha}
Nombre: {nombre}
Telefono: {telefono}
Nivel de Prioridad: {prioridad}
Observacion: {observacion}
Fecha: {DateTime.Now}
///////////////////////////////////////";
            try
            {
                using (StreamWriter sw = File.AppendText(LogFilePath))
                {
                    sw.WriteLine(logEntry);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error al escribir en el archivo de log: {ex.Message}");
            }
        }
    }
}

//Console.WriteLine($"{user}, el resultado de su suma ({a} + {b}) es {resultado}");
//Logger.Instance.Log(user, "Suma", $"{a} + {b} ", resultado.ToString());
//MenuRegreso menu = new MenuRegreso();
//menu.menuRegreso(user);