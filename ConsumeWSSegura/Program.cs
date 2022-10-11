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
            ConsumeHelloWorldSinSeguridad();
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
    }
}
