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
            if ( this.UserName == Properties.Settings.Default.UserName && this.Password == Properties.Settings.Default.Password)
            {
                return true;
            }
            else
            {
                return false;
            }            
        }

    }
}