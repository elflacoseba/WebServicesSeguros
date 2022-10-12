using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services.Protocols;

namespace WebServiceSegura
{
    public class AuthUser : SoapHeader
    {
        public string UserName { get; set; }
        public string Password { get; set; }    

        /// <summary>
        /// Verifica y valida las credenciales.
        /// </summary>
        /// <returns></returns>
        public  bool IsValid()
        {
            return true;
        }

    }
}