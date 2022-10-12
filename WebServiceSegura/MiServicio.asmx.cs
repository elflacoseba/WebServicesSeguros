using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;

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
        /// <summary>
        /// Almacena las credenciales del usuario.
        /// </summary>
        public AuthUser authUser;

        [WebMethod(Description = "`Método seguro.")]
        [SoapHeader("authUser")]
        public string HelloWorldSeguro()
        {
            if (this.authUser != null && this.authUser.IsValid())
            {
                return "Hola a todos desde un método que implementa seguridad mediante credenciales enviadas en el header.";
            }
            else
            {
                return "Credenciales incorrectas!";
            }                       
        }

        [WebMethod(Description = "`Método sin seguridad.")]
        public string HelloWorldSinSeguridad()
        {
            return "Hola a todos desde un método sin seguridad.";
        }
    }
}
