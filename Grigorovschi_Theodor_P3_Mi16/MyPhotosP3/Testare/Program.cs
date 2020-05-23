using ClassLibraryMyPhotosP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testare
{
    class Program
    {
        static void Main(string[] args)
        {
            /*InterfaceApiClient client = new InterfaceApiClient();

            // Use the 'client' variable to call operations on the service.
            client.PreluarePoza(@"C:\Users\Theo\Pictures\1.png");
            // Always close the client.
            client.Close();*/
            APIP2 api = new APIP2();
            api.PreluarePoza(@"C:\Users\Theo\Pictures\1.png");
        }
    }
}
