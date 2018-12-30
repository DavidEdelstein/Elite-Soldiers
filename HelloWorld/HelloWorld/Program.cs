using HelloWorld;
using System;

namespace OOPInterfacesInheritence
{
    class Program
    {
        static void Main(string[] args)
        {

            //look up aventis on that great video that i watched
            var navySeal = new NavySeal();
            var Recon = navySeal.Recon();

            Console.WriteLine(Recon);
            Console.ReadKey();
        }
    }
}
