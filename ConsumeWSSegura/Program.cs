using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsumeWSSegura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ConsumeHelloWorldSinSeguridad();

            ConsumeHelloWorldSeguro();
        }

        private static void ConsumeHelloWorldSinSeguridad()
        {
            using (var client = new MiServicioReference.MiServicioSoapClient())
            {
                string result = client.HelloWorldSinSeguridad();

                Console.WriteLine(result);

                Console.ReadKey();
            }
        }

        private static void ConsumeHelloWorldSeguro()
        {
            using (var client = new MiServicioReference.MiServicioSoapClient())
            {
                MiServicioReference.AuthUser authUser = new MiServicioReference.AuthUser { UserName = "elflacoseba", Password = "1234" };               

                string result = client.HelloWorldSeguro(authUser);

                Console.WriteLine(result);

                Console.ReadKey();
            }
        }
                
    }
}
