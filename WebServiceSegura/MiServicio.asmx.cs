using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebServiceSegura
{
    /// <summary>
    /// Descripción breve de MiServicio
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class MiServicio : System.Web.Services.WebService
    {

        [WebMethod(Description = "`Método seguro.")]
        public string HelloWorldSeguro()
        {
            return "Hola a todos desde un método que implementa seguridad mediante credenciales enviadas en el header.";
        }

        [WebMethod(Description = "`Método sin seguridad.")]
        public string HelloWorldSinSeguridad()
        {
            return "Hola a todos desde un método sin seguridad.";
        }
    }
}
