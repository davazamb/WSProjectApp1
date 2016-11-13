using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WSApp
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione Service1.svc o Service1.svc.cs en el Explorador de soluciones e inicie la depuración.
    public class WSPersonas : IWSPersonas
    {
        public Persona ObtenerPersona(string Identificacion)
        {
            if(Identificacion == "0")
            {
                return new Persona() { Nombre = "David", Edad = 31 };
            }
            else if (Identificacion == "0")
            {
                return new Persona() { Nombre = "Isane", Edad = 30 };
            }
            else
            {
                return new Persona() { Error = "Persona no encontrada" };
            }
        }
    }
}
