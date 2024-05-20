using Newtonsoft.Json;
using PracticaDos.Clases_Esenciales;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace PracticaDos.ArchivoJson
{
    internal class GuardarDatos
    {
        public static void SerializeJsonFile(List<Usuario> usuarios)
        {
            string informacionJson = JsonConvert.SerializeObject(usuarios.ToArray(), Formatting.Indented);
            File.WriteAllText(Program.JsonPath, informacionJson);
        }

        public static List<Usuario> GetUsuarioInformacion(string userName, string password, string tipo)
        {
            List<Usuario> usuarios = new List<Usuario>
            {
                new Usuario
                {
                    UserName = userName,
                    Password = password
                }
            };
            return usuarios;
        }

        public static string GetInformacionInicioSesion()
        {
            string informacionRegistro;
            using(var reader = new StreamReader(Program.JsonPath))
            {
                informacionRegistro = reader.ReadLine();
            }
            return informacionRegistro;
        }

        public static List<Usuario> DeserializeJsonFile()
        {
            try
            {
                string jstonText = File.ReadAllText(Program.JsonPath);
                List<Usuario> usuarios = JsonConvert.DeserializeObject<List<Usuario>>(jstonText);
                return usuarios;
            }
            catch (Exception ex) 
            {
                Console.WriteLine("Error al cargar los usuarios registrados: "+ ex.Message);
                return new List<Usuario>();
            }
        }
    }
}
