using ClassLibraryMyPhotosP2;
using MyPhotosP2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testare2
{
    class Program
    {
        static void Main(string[] args)
        {
            //InterfaceApiClient client = new InterfaceApiClient();

            // Use the 'client' variable to call operations on the service.
            //client.PreluarePoza(@"C:\Users\Theo\Pictures\aici.png");
            // Always close the client.
            APIP2 api = new APIP2();
            /*foreach (DTO d in api.GetAllPhotos()) {
                Console.WriteLine(d.Path);
            }*/
            foreach (Proprietati p in api.CautarePropPhoto(3))
            {
                Console.WriteLine(p.NumeCamp);
            }
            //client.Close(); 
        }
    }
}
