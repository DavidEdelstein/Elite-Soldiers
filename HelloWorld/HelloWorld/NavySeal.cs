using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class NavySeal : ISoldier
    {
        public bool Sniper => true;
        public bool Elite => true;
        public bool UnderwaterWarefare => true;
        public bool AntiTerrorist => false;

        public string Recon()
        {
            //Console.WriteLine("Navy Seal can do Recon");
            return "Navy Seal can do Recon";
        }

        public void ResiliantSurvive()
        {
            Console.WriteLine("This Navy Seal can survive harsh situations");
        }

        public void Shoot()
        {
            Console.WriteLine("This Navy Seal is a great shot!!");
        }
    }
}
